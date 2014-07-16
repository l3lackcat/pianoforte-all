﻿'use strict';

goog.provide('PianoForte.App');

goog.require('PianoForte.Controllers.Books.BookController');
goog.require('PianoForte.Controllers.Books.BookMainController');

goog.require('PianoForte.Directives.Books.GeneralInfoEditorDirective');
goog.require('PianoForte.Controllers.Books.GeneralInfoEditorController');

goog.require('PianoForte.Controllers.Cds.CdController');
goog.require('PianoForte.Controllers.Cds.CdMainController');

goog.require('PianoForte.Directives.Cds.GeneralInfoEditorDirective');
goog.require('PianoForte.Controllers.Cds.GeneralInfoEditorController');

goog.require('PianoForte.Controllers.Courses.CourseController');
goog.require('PianoForte.Controllers.Courses.CourseMainController');

goog.require('PianoForte.Controllers.Students.StudentController');
goog.require('PianoForte.Controllers.Students.StudentMainController');

goog.require('PianoForte.Controllers.Teachers.TeacherController');
goog.require('PianoForte.Controllers.Teachers.TeacherMainController');

goog.require('PianoForte.Directives.Teachers.ContactInfoEditorDirective');
goog.require('PianoForte.Controllers.Teachers.ContactInfoEditorController');

goog.require('PianoForte.Directives.Teachers.GeneralInfoEditorDirective');
goog.require('PianoForte.Controllers.Teachers.GeneralInfoEditorController');

goog.require('PianoForte.Directives.Teachers.RegisterDirective');
goog.require('PianoForte.Controllers.Teachers.RegisterController');

goog.require('PianoForte.Directives.Teachers.TeachedCourseInfoEditorDirective');
goog.require('PianoForte.Controllers.Teachers.TeachedCourseInfoEditorController');

goog.require('PianoForte.Directives.Widgets.MyBoxDirective');
goog.require('PianoForte.Controllers.Widgets.MyBoxController');

goog.require('PianoForte.Directives.Widgets.MyButtonDirective');
goog.require('PianoForte.Controllers.Widgets.MyButtonController');

goog.require('PianoForte.Directives.Widgets.MyCheckboxDirective');
goog.require('PianoForte.Controllers.Widgets.MyCheckboxController');

goog.require('PianoForte.Directives.Widgets.MyDialogBoxDirective');
goog.require('PianoForte.Controllers.Widgets.MyDialogBoxController');

goog.require('PianoForte.Directives.Widgets.MyDropdownMenuDirective');
goog.require('PianoForte.Controllers.Widgets.MyDropdownMenuController');

goog.require('PianoForte.Directives.Widgets.MyLeftMenuDirective');
goog.require('PianoForte.Controllers.Widgets.MyLeftMenuController');

goog.require('PianoForte.Directives.Widgets.MyNumericBoxDirective');
goog.require('PianoForte.Controllers.Widgets.MyNumericBoxController');

goog.require('PianoForte.Directives.Widgets.MyPhoneBoxDirective');
goog.require('PianoForte.Controllers.Widgets.MyPhoneBoxController');

goog.require('PianoForte.Directives.Widgets.MySearchBoxDirective');
goog.require('PianoForte.Controllers.Widgets.MySearchBoxController');

goog.require('PianoForte.Directives.Widgets.MySelectDirective');
goog.require('PianoForte.Controllers.Widgets.MySelectController');

goog.require('PianoForte.Directives.Widgets.MyPaneDirective');
goog.require('PianoForte.Directives.Widgets.MyTabsDirective');
goog.require('PianoForte.Controllers.Widgets.MyTabsController');

goog.require('PianoForte.Directives.Widgets.MyTextBoxDirective');
goog.require('PianoForte.Controllers.Widgets.MyTextBoxController');

goog.require('PianoForte.Enum');

goog.require('PianoForte.Models.LocationDataModel');

goog.require('PianoForte.Services.BookService');
goog.require('PianoForte.Services.CdService');
goog.require('PianoForte.Services.CourseService');
goog.require('PianoForte.Services.StudentService');
goog.require('PianoForte.Services.TeacherService');

goog.require('PianoForte.Utilities.EnumConverter');
goog.require('PianoForte.Utilities.FormatManager');
goog.require('PianoForte.Utilities.LocationManager');
goog.require('PianoForte.Utilities.ValidationManager');

PianoForte.App = angular.module('PianoForteApplication', ['ngRoute']);

PianoForte.App.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/', {
            controller: 'TeacherMainController',
            templateUrl: 'partials/teachers/main.htm'
        })
        .when('/books', {
            controller: 'BookMainController',
            templateUrl: 'partials/books/main.htm'
        })
        .when('/books/:bookId', {
            controller: 'BookController',
            templateUrl: 'partials/books/book.htm'
        })
        .when('/cds', {
            controller: 'CdMainController',
            templateUrl: 'partials/cds/main.htm'
        })
        .when('/cds/:cdId', {
            controller: 'CdController',
            templateUrl: 'partials/cds/cd.htm'
        })
        .when('/courses', {
            controller: 'CourseMainController',
            templateUrl: 'partials/courses/main.htm'
        })
        .when('/courses', {
            controller: 'CourseController',
            templateUrl: 'partials/courses/course.htm'
        })
        .when('/students', {
            controller: 'StudentMainController',
            templateUrl: 'partials/students/main.htm'
        })
        .when('/students/:studentId', {
            controller: 'StudentController',
            templateUrl: 'partials/students/student.htm'
        })
		.when('/teachers', {
		    controller: 'TeacherMainController',
		    templateUrl: 'partials/teachers/main.htm'
		})            
        .when('/teachers/:teacherId', {
            controller: 'TeacherController',
            templateUrl: 'partials/teachers/teacher.htm'
        })                       
        .otherwise({
            redirectTo: '/'
        });
}]);

//We already have a limitTo filter built-in to angular,
//let's make a startFrom filter
PianoForte.App.filter('startFrom', function() {
    return function(input, start) {
        start = +start; //parse to int
        return input.slice(start);
    }
});

// Book
PianoForte.App.controller('BookController', ['$scope', '$rootScope', '$routeParams', 'BookService', 'Enum', 'EnumConverter', 'FormatManager', 'ValidationManager', PianoForte.Controllers.Books.BookController]);
PianoForte.App.controller('BookMainController', ['$scope', '$rootScope', 'filterFilter', 'BookService', 'EnumConverter', 'FormatManager', PianoForte.Controllers.Books.BookMainController]);

// BookGeneralInfoEditor
PianoForte.App.directive('bookGeneralInfoEditor', PianoForte.Directives.Books.GeneralInfoEditorDirective);
PianoForte.App.controller('Book.GeneralInfoEditorController', ['$scope', '$rootScope', 'BookService', 'Enum', 'EnumConverter', 'ValidationManager', PianoForte.Controllers.Books.GeneralInfoEditorController]);

// Cd
PianoForte.App.controller('CdController', ['$scope', '$rootScope', '$routeParams', 'CdService', 'Enum', 'EnumConverter', 'FormatManager', 'ValidationManager', PianoForte.Controllers.Cds.CdController]);
PianoForte.App.controller('CdMainController', ['$scope', '$rootScope', 'filterFilter', 'CdService', 'EnumConverter', 'FormatManager', PianoForte.Controllers.Cds.CdMainController]);

// CdGeneralInfoEditor
PianoForte.App.directive('cdGeneralInfoEditor', PianoForte.Directives.Cds.GeneralInfoEditorDirective);
PianoForte.App.controller('Cd.GeneralInfoEditorController', ['$scope', '$rootScope', 'CdService', 'Enum', 'EnumConverter', 'ValidationManager', PianoForte.Controllers.Cds.GeneralInfoEditorController]);

// Course
PianoForte.App.controller('CourseController', ['$scope', '$rootScope', '$routeParams', 'CourseService', 'Enum', 'EnumConverter', 'FormatManager', 'ValidationManager', PianoForte.Controllers.Courses.CourseController]);
PianoForte.App.controller('CourseMainController', ['$scope', '$rootScope', 'filterFilter', 'CourseService', 'EnumConverter', 'FormatManager', PianoForte.Controllers.Courses.CourseMainController]);

// Student
PianoForte.App.controller('StudentController', ['$scope', '$rootScope', '$routeParams', 'StudentService', 'Enum', 'EnumConverter', 'FormatManager', 'ValidationManager', PianoForte.Controllers.Students.TeacherController]);
PianoForte.App.controller('StudentMainController', ['$scope', '$rootScope', 'filterFilter', 'StudentService', 'EnumConverter', 'FormatManager', PianoForte.Controllers.Students.StudentMainController]);

// Teacher
PianoForte.App.controller('TeacherController', ['$scope', '$rootScope', '$routeParams', 'TeacherService', 'CourseService', 'Enum', 'EnumConverter', 'FormatManager', 'ValidationManager', PianoForte.Controllers.Teachers.TeacherController]);
PianoForte.App.controller('TeacherMainController', ['$scope', '$rootScope', '$location', 'filterFilter', 'TeacherService', 'Enum', 'EnumConverter', 'FormatManager', PianoForte.Controllers.Teachers.TeacherMainController]);

// TeacherContactInfoEditor
PianoForte.App.directive('teacherContactInfoEditor', PianoForte.Directives.Teachers.ContactInfoEditorDirective);
PianoForte.App.controller('Teacher.ContactInfoEditorController', ['$scope', '$rootScope', 'TeacherService', 'Enum', 'EnumConverter', 'FormatManager', 'ValidationManager', PianoForte.Controllers.Teachers.ContactInfoEditorController]);

// TeacherGeneralInfoEditor
PianoForte.App.directive('teacherGeneralInfoEditor', PianoForte.Directives.Teachers.GeneralInfoEditorDirective);
PianoForte.App.controller('Teacher.GeneralInfoEditorController', ['$scope', '$rootScope', 'TeacherService', 'Enum', 'EnumConverter', 'ValidationManager', PianoForte.Controllers.Teachers.GeneralInfoEditorController]);

// TeacherRegister
PianoForte.App.directive('teacherRegister', PianoForte.Directives.Teachers.RegisterDirective);
PianoForte.App.controller('RegisterController', ['$scope', '$rootScope', 'TeacherService', 'ValidationManager', PianoForte.Controllers.Teachers.RegisterController]);

// TeacherTeachedCourseInfoEditor
PianoForte.App.directive('teacherTeachedCourseInfoEditor', PianoForte.Directives.Teachers.TeachedCourseInfoEditorDirective);
PianoForte.App.controller('Teacher.TeachedCourseInfoEditorController', ['$scope', '$rootScope', 'TeacherService', 'Enum', 'EnumConverter', 'ValidationManager', PianoForte.Controllers.Teachers.TeachedCourseInfoEditorController]);

// MyBox
PianoForte.App.directive('myBox', PianoForte.Directives.Widgets.MyBoxDirective);
PianoForte.App.controller('MyBoxController', ['$scope', PianoForte.Controllers.Widgets.MyBoxController]);

// MyButton
PianoForte.App.directive('myButton', PianoForte.Directives.Widgets.MyButtonDirective);
PianoForte.App.controller('MyButtonController', ['$scope', '$attrs', '$element', PianoForte.Controllers.Widgets.MyButtonController]);

// MyCheckbox
PianoForte.App.directive('myCheckbox', PianoForte.Directives.Widgets.MyCheckboxDirective);
PianoForte.App.controller('MyCheckboxController', ['$scope', '$attrs', '$element', PianoForte.Controllers.Widgets.MyCheckboxController]);

// MyDialogBox
PianoForte.App.directive('myDialogBox', PianoForte.Directives.Widgets.MyDialogBoxDirective);
PianoForte.App.controller('MyDialogBoxController', ['$scope', '$attrs', '$element', '$rootScope', PianoForte.Controllers.Widgets.MyDialogBoxController]);

// MyDropdownMenu
PianoForte.App.directive('myDropdownMenu', PianoForte.Directives.Widgets.MyDropdownMenuDirective);
PianoForte.App.controller('MyDropdownMenuController', ['$scope', '$attrs', '$element', '$document', 'filterFilter', PianoForte.Controllers.Widgets.MyDropdownMenuController]);

// MyLeftMenu
PianoForte.App.directive('myLeftMenu', PianoForte.Directives.Widgets.MyLeftMenuDirective);
PianoForte.App.controller('MyLeftMenuController', ['$scope', '$attrs', '$element', PianoForte.Controllers.Widgets.MyLeftMenuController]);

// MyNumericBox
PianoForte.App.directive('myNumericBox', PianoForte.Directives.Widgets.MyNumericBoxDirective);
PianoForte.App.controller('MyNumericBoxController', ['$scope', '$attrs', '$element', 'FormatManager', PianoForte.Controllers.Widgets.MyNumericBoxController]);

// MyPhoneBox
PianoForte.App.directive('myPhoneBox', PianoForte.Directives.Widgets.MyPhoneBoxDirective);
PianoForte.App.controller('MyPhoneBoxController', ['$scope', '$attrs', '$element', 'FormatManager', PianoForte.Controllers.Widgets.MyPhoneBoxController]);

// MySearchBox
PianoForte.App.directive('mySearchBox', PianoForte.Directives.Widgets.MySearchBoxDirective);
PianoForte.App.controller('MySearchBoxController', ['$scope', '$attrs', '$element', PianoForte.Controllers.Widgets.MySearchBoxController]);

// MySelect
PianoForte.App.directive('mySelect', PianoForte.Directives.Widgets.MySelectDirective);
PianoForte.App.controller('MySelectController', ['$scope', '$attrs', '$element', '$document', PianoForte.Controllers.Widgets.MySelectController]);

// MyTabs
PianoForte.App.directive('myPane', PianoForte.Directives.Widgets.MyPaneDirective);
PianoForte.App.directive('myTabs', PianoForte.Directives.Widgets.MyTabsDirective);
PianoForte.App.controller('MyTabsController', ['$scope', '$attrs', '$element', PianoForte.Controllers.Widgets.MyTabsController]);

// MyTextBox
PianoForte.App.directive('myTextBox', PianoForte.Directives.Widgets.MyTextBoxDirective);
PianoForte.App.controller('MyTextBoxController', ['$scope', '$attrs', '$element', PianoForte.Controllers.Widgets.MyTextBoxController]);

PianoForte.App.service('Enum', [PianoForte.Enum]);
PianoForte.App.service('EnumConverter', ['Enum', PianoForte.Utilities.EnumConverter]);
PianoForte.App.service('FormatManager', ['ValidationManager', PianoForte.Utilities.FormatManager]);
PianoForte.App.service('LocationManager', ['LocationDataModel', PianoForte.Utilities.LocationManager]);
PianoForte.App.service('ValidationManager', [PianoForte.Utilities.ValidationManager]);

PianoForte.App.service('BookService', ['$http', 'FormatManager', PianoForte.Services.BookService]);
PianoForte.App.service('CdService', ['$http', 'FormatManager', PianoForte.Services.CdService]);
PianoForte.App.service('CourseService', ['$http', 'FormatManager', PianoForte.Services.CourseService]);
PianoForte.App.service('StudentService', ['$http', PianoForte.Services.StudentService]);
PianoForte.App.service('TeacherService', ['$http', PianoForte.Services.TeacherService]);