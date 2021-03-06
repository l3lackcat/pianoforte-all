﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using PianoForte.Enum;
using PianoForte.Models;
using PianoForte.Services;
using PianoForte.Utilities;

namespace PianoForte.WebServices
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class TeacherWebService : System.Web.Services.WebService
    {
        private int delay = 1500;

        [WebMethod]
        public List<Object> getTeacherList(string databaseName)
        {
            System.Threading.Thread.Sleep(delay);

            List<Object> displayedTeacherList = new List<Object>();
            List<Teacher> teacherList = TeacherService.getTeacherList(databaseName);
            foreach(Teacher teacher in teacherList)
            {
                teacher.ContactList = TeacherContactService.getTeacherContactList(databaseName, teacher.Id, Status.ACTIVE);

                string phoneNumber = "-";
                foreach (TeacherContact contact in teacher.ContactList)
                {
                    if (contact.Type == ContactType.PHONE)
                    {
                        if (phoneNumber == "-")
                        {
                            phoneNumber = contact.Content;
                        }
                        else
                        {
                            if (contact.IsPrimary)
                            {
                                phoneNumber = contact.Content;
                                break;
                            }
                        }                        
                    }
                }

                displayedTeacherList.Add(new {
                    id = teacher.Id,
                    name = teacher.Firstname + " " + teacher.Lastname,
                    nickname = teacher.Nickname,
                    phoneNumber = phoneNumber,
                    status = teacher.Status
                });
            }

            return displayedTeacherList;
        }

        [WebMethod]
        public Object getTeacherById(string databaseName, int id)
        {
            System.Threading.Thread.Sleep(delay);

            Object teacher = null;
            List<Object> phoneList = new List<Object>();
            List<Object> emailList = new List<Object>();            

            Teacher tempTeacher = TeacherService.getTeacher(databaseName, id);
            if (tempTeacher != null)
            {      
                //Contact list
                tempTeacher.ContactList = TeacherContactService.getTeacherContactList(databaseName, tempTeacher.Id, Status.ACTIVE);
                foreach(TeacherContact contact in tempTeacher.ContactList)
                {
                    if (contact.Type == ContactType.PHONE)
                    {
                        phoneList.Add(new {
                            id = contact.Id,
                            label = contact.Label,
                            value = contact.Content,
                            status = contact.Status,
                            isPrimary = contact.IsPrimary
                        });
                    }
                    else if (contact.Type == ContactType.EMAIL)
                    {
                        emailList.Add(new {
                            id = contact.Id,
                            label = contact.Label,
                            value = contact.Content,
                            status = contact.Status,
                            isPrimary = contact.IsPrimary
                        });
                    }
                }

                //Teached course list
                List<int> teachedCourseIdList = TeachedCourseService.getTeachedCourseIdList(databaseName, tempTeacher.Id);
                foreach (int teachedCourseId in teachedCourseIdList)
                {
                    Course course = CourseService.getCourse(databaseName, teachedCourseId);
                    if (course != null)
                    {
                        if (tempTeacher.TeachedCourseList.Contains(course.Name) == false)
                        {
                            tempTeacher.TeachedCourseList.Add(course.Name);
                        }
                    }
                }

                teacher = new {
                    id = tempTeacher.Id,
                    firstname = tempTeacher.Firstname,
                    lastname = tempTeacher.Lastname,
                    nickname = tempTeacher.Nickname,
                    status = tempTeacher.Status,
                    phoneList = phoneList,
                    emailList = emailList,
                    teachedCourseList = tempTeacher.TeachedCourseList
                };
            }

            return teacher;
        }

        [WebMethod]
        public int insertTeacherGeneralInfo(string databaseName, Teacher teacher)
        {
            System.Threading.Thread.Sleep(delay);
            
            teacher.Id = TeacherService.getNextTeacherId(databaseName);

            bool isInsertSuccess = TeacherService.insertTeacher(databaseName, teacher);
            if (isInsertSuccess == false)
            {
                teacher.Id = 0;
            }

            return teacher.Id;
        }

        [WebMethod]
        public bool updateTeacherGeneralInfo(string databaseName, Teacher teacher)
        {
            System.Threading.Thread.Sleep(delay);
            return TeacherService.updateTeacher(databaseName, teacher);
        }

        [WebMethod]
        public int insertTeacherContactInfo(string databaseName, TeacherContact teacherContact)
        {
            System.Threading.Thread.Sleep(delay);

            int contactId = 0;

            bool isSuccess = TeacherContactService.insertTeacherContact(databaseName, teacherContact);
            if (isSuccess)
            {
                TeacherContact tempTeacherContact = TeacherContactService.getTeacherContact(databaseName, teacherContact.TeacherId, teacherContact.Type, teacherContact.Label, teacherContact.Content);
                if (tempTeacherContact != null)
                {
                    contactId = tempTeacherContact.Id;
                }                
            }

            return contactId;
        }

        [WebMethod]
        public bool updateTeacherContactInfo(string databaseName, TeacherContact teacherContact)
        {
            System.Threading.Thread.Sleep(5000);
            return TeacherContactService.updateTeacherContact(databaseName, teacherContact);
        }

        [WebMethod]
        public bool deleteTeacherContactInfo(string databaseName, TeacherContact teacherContact)
        {
            System.Threading.Thread.Sleep(delay);
            return TeacherContactService.deleteTeacherContact(databaseName, teacherContact.Id);
        }

        [WebMethod]
        public bool updateTeachedCourseInfo(int teacherId, string databaseName, List<string> teachedCourseNameList)
        {
            System.Threading.Thread.Sleep(delay);

            bool isUpdateSuccess = true;

            if (TeachedCourseService.deleteTeachedCourseListByTeacherId(databaseName, teacherId))
            {
                foreach(string courseName in teachedCourseNameList)
                {
                    List<Course> courseList = CourseService.getCourseListByName(databaseName, courseName, Status.ACTIVE);
                    foreach(Course course in courseList)
                    {
                        bool isSuccess = TeachedCourseService.insertTeachedCourse(databaseName, teacherId, course.Id);

                        if (isUpdateSuccess)
                        {
                            isUpdateSuccess = isSuccess; 
                        }
                    }
                }
            }

            return isUpdateSuccess;
        }
    }
}
