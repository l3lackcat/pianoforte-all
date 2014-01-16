﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;

using MySql.Data.MySqlClient;

using PianoForte.Enum;
using PianoForte.Models;
using PianoForte.Resourses.DatabaseStructure.MySqlTable;

namespace PianoForte.Dao
{
    public class CdDaoImplMySql : CdDao
    {
        private bool insert(string databaseName, Cd cd, string sql)
        {
            bool returnFlag = false;

            if (cd != null)
            {
                MySqlConnection conn = null;
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

                    conn = new MySqlConnection(connectionString);
                    if (conn != null)
                    {
                        conn.Open();

                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue(Cds.ColumnCdId, cd.Id);
                        command.Parameters.AddWithValue(Cds.ColumnCdInternalBarcode, cd.InternalBarcode);
                        command.Parameters.AddWithValue(Cds.ColumnCdOriginalBarcode, cd.OriginalBarcode);
                        command.Parameters.AddWithValue(Cds.ColumnCdName, cd.Name);
                        command.Parameters.AddWithValue(Cds.ColumnCdUnitPrice, cd.UnitPrice);
                        command.Parameters.AddWithValue(Cds.ColumnCdQuantity, cd.Quantity);
                        command.Parameters.AddWithValue(Cds.ColumnCdStatus, (int)cd.Status);

                        int affectedRow = command.ExecuteNonQuery();
                        if (affectedRow != -1)
                        {
                            returnFlag = true;
                        }
                    }
                }
                catch (System.InvalidOperationException e)
                {
                    Console.Write(e.Message);
                }
                catch (MySqlException e)
                {
                    Console.Write(e.Message);
                }
                catch (System.SystemException e)
                {
                    Console.Write(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return returnFlag;
        }

        private bool update(string databaseName, Cd cd, string sql)
        {
            bool returnFlag = false;

            if (cd != null)
            {
                MySqlConnection conn = null;
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

                    conn = new MySqlConnection(connectionString);
                    if (conn != null)
                    {
                        conn.Open();

                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.AddWithValue(Cds.ColumnCdInternalBarcode, cd.InternalBarcode);
                        command.Parameters.AddWithValue(Cds.ColumnCdOriginalBarcode, cd.OriginalBarcode);
                        command.Parameters.AddWithValue(Cds.ColumnCdName, cd.Name);
                        command.Parameters.AddWithValue(Cds.ColumnCdUnitPrice, cd.UnitPrice);
                        command.Parameters.AddWithValue(Cds.ColumnCdQuantity, cd.Quantity);
                        command.Parameters.AddWithValue(Cds.ColumnCdStatus, (int)cd.Status);
                        command.Parameters.AddWithValue(Cds.ColumnCdId, cd.Id);

                        int affectedRow = command.ExecuteNonQuery();
                        if (affectedRow != -1)
                        {
                            returnFlag = true;
                        }
                    }
                }
                catch (System.InvalidOperationException e)
                {
                    Console.Write(e.Message);
                }
                catch (MySqlException e)
                {
                    Console.Write(e.Message);
                }
                catch (System.SystemException e)
                {
                    Console.Write(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return returnFlag;
        }

        private Cd selectCd(string databaseName, string sql)
        {
            Cd cd = null;

            MySqlConnection conn = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

                conn = new MySqlConnection(connectionString);
                if (conn != null)
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                    DataSet data = new DataSet();
                    dataAdapter.Fill(data, Cds.TableName);

                    for (int i = 0; i < data.Tables[Cds.TableName].Rows.Count; i++)
                    {
                        cd = new Cd();
                        cd.Id = Convert.ToInt32(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdId].ToString());
                        cd.InternalBarcode = data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdInternalBarcode].ToString();
                        cd.OriginalBarcode = data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdOriginalBarcode].ToString();
                        cd.Name = data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdName].ToString();
                        cd.UnitPrice = Convert.ToDouble(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdUnitPrice].ToString());
                        cd.Quantity = Convert.ToInt32(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdQuantity].ToString());
                        cd.Status = EnumConverter.ToStatus(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdStatus].ToString());
                    }
                }
            }
            catch (System.InvalidOperationException e)
            {
                Console.Write(e.Message);
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
            }
            catch (System.SystemException e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return cd;
        }

        private List<Cd> selectCdList(string databaseName, string sql)
        {
            List<Cd> cdList = new List<Cd>();

            MySqlConnection conn = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;

                conn = new MySqlConnection(connectionString);
                if (conn != null)
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                    DataSet data = new DataSet();
                    dataAdapter.Fill(data, Cds.TableName);

                    for (int i = 0; i < data.Tables[Cds.TableName].Rows.Count; i++)
                    {
                        Cd cd = new Cd();
                        cd.Id = Convert.ToInt32(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdId].ToString());
                        cd.InternalBarcode = data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdInternalBarcode].ToString();
                        cd.OriginalBarcode = data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdOriginalBarcode].ToString();
                        cd.Name = data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdName].ToString();
                        cd.UnitPrice = Convert.ToDouble(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdUnitPrice].ToString());
                        cd.Quantity = Convert.ToInt32(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdQuantity].ToString());
                        cd.Status = EnumConverter.ToStatus(data.Tables[Cds.TableName].Rows[i][Cds.ColumnCdStatus].ToString());

                        cdList.Add(cd);
                    }
                }
            }
            catch (System.InvalidOperationException e)
            {
                Console.Write(e.Message);
            }
            catch (MySqlException e)
            {
                Console.Write(e.Message);
            }
            catch (System.SystemException e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return cdList;
        }

        public bool insertCd(string databaseName, Cd cd)
        {
            string sql = "INSERT INTO " +
                         Cds.TableName + " (" +
                         Cds.ColumnCdId + ", " +
                         Cds.ColumnCdInternalBarcode + ", " +
                         Cds.ColumnCdOriginalBarcode + ", " +
                         Cds.ColumnCdName + ", " +
                         Cds.ColumnCdUnitPrice + ", " +
                         Cds.ColumnCdQuantity + ", " +
                         Cds.ColumnCdStatus + ") " +
                         "VALUES(" +
                         "?" + Cds.ColumnCdId + ", " +
                         "?" + Cds.ColumnCdInternalBarcode + ", " +
                         "?" + Cds.ColumnCdOriginalBarcode + ", " +
                         "?" + Cds.ColumnCdName + ", " +
                         "?" + Cds.ColumnCdUnitPrice + ", " +
                         "?" + Cds.ColumnCdQuantity + ", " +
                         "?" + Cds.ColumnCdStatus + ")";

            return this.insert(databaseName, cd, sql);
        }

        public bool updateCd(string databaseName, Cd cd)
        {
            string sql = "UPDATE " +
                         Cds.TableName + " SET " +
                         Cds.ColumnCdInternalBarcode + " = ?" + Cds.ColumnCdInternalBarcode + ", " +
                         Cds.ColumnCdOriginalBarcode + " = ?" + Cds.ColumnCdOriginalBarcode + ", " +
                         Cds.ColumnCdName + " = ?" + Cds.ColumnCdName + ", " +
                         Cds.ColumnCdUnitPrice + " = ?" + Cds.ColumnCdUnitPrice + ", " +
                         Cds.ColumnCdQuantity + " = ?" + Cds.ColumnCdQuantity + ", " +
                         Cds.ColumnCdStatus + " = ?" + Cds.ColumnCdStatus + " " +
                         "WHERE " + Cds.ColumnCdId + " = ?" + Cds.ColumnCdId;

            return this.update(databaseName, cd, sql);
        }

        public Cd getCd(string databaseName, int cdId)
        {
            string sql = "SELECT * " +
                         "FROM " + Cds.TableName + " " +
                         "WHERE " + Cds.ColumnCdId + " = " + cdId;

            return this.selectCd(databaseName, sql);
        }

        public Cd getLastCd(string databaseName)
        {
            string sql = "SELECT * " +
                         "FROM " + Cds.TableName + " " +
                         "ORDER BY " + Cds.ColumnCdId + " DESC " +
                         "LIMIT 1";

            return this.selectCd(databaseName, sql);
        }

        public List<Cd> getCdList(string databaseName)
        {
            string sql = "SELECT * " +
                         "FROM " + Cds.TableName + " " +
                         "ORDER BY " + Cds.ColumnCdId + " ASC";

            return this.selectCdList(databaseName, sql);
        }

        public List<Cd> getCdList(string databaseName, int startIndex, int offset)
        {
            string sql = "SELECT * " +
                         "FROM " + Cds.TableName + " " +
                         "ORDER BY " + Cds.ColumnCdId + " ASC " +
                         "LIMIT " + startIndex + "," + offset;

            return this.selectCdList(databaseName, sql);
        }

        public List<Cd> getCdList(string databaseName, int startIndex, int offset, string keyword)
        {
            string sql = "SELECT * " +
                         "FROM " + Cds.TableName + " " +
                         "WHERE " + Cds.ColumnCdName + " LIKE '%" + keyword + "%' " +
                         "ORDER BY " + Cds.ColumnCdId + " ASC " +
                         "LIMIT " + startIndex + "," + offset;

            return this.selectCdList(databaseName, sql);
        }

        public List<Cd> getCdListByName(string databaseName, string cdName)
        {
            string sql = "SELECT * " +
                         "FROM " + Cds.TableName + " " +
                         "WHERE " + Cds.ColumnCdName + " = '" + cdName + "' " +
                         "ORDER BY " + Cds.ColumnCdId + " ASC";

            return this.selectCdList(databaseName, sql);
        }
    }
}