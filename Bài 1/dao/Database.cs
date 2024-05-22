﻿using Bài_1.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bài_1.dao
{
    public class Database
    {
        public static Database instance { get; private set; }
        public Dictionary<string, List<BaseRow>> database;
        /*
         * Hàm khởi tạo Database
         */
        public Database()
        {
            if (instance == null)
            {
                database = new Dictionary<string, List<BaseRow>>();
                instance = this;
            }
            else
            {
                Console.WriteLine("singleton is init");
                return;
            }      
        }
        /*
         *Thêm đối tượng vào database theo kiểu name
         */
        public void InsertTable(string name, BaseRow _object)
        {
            if (!database.ContainsKey(name))
            {

                database[name] = new List<BaseRow>();
            }

            database[name].Add(_object);
        }
        /*
         * Lấy tất cả đối tượng của kiểu name
         */
        public List<BaseRow> SelectTable(string name)
        {
            List<BaseRow> result = database[name];

            return result;
        }
        /*
         *Cập nhật đối tượng theo kiểu name với id 
         */
        public void UpdateTable(string name, BaseRow _object,int id)
        {
            if (!database.ContainsKey(name))
            {
                Console.WriteLine("Don't have object type " + name);
            }
            else
            {
                foreach (BaseRow obj in database[name])
                {
                    if (obj.GetId() == id)
                    {
                        int index = database[name].IndexOf(obj);

                        database[name][index] = _object;

                        return;
                    }
                }
            }
        }
        /*
         * Xoá đối tượng với kiểu name theo id
         */
        public void DeleteTable(string name,int id)
        {
            if (!database.ContainsKey(name))
            {
                Console.WriteLine("Don't have object type " + name);
            }
            else
            {
                foreach (BaseRow obj in database[name])
                {
                    if (obj.GetId() == id)
                    {
                        database[name].Remove(obj);

                        return;
                    }
                }
            }
        }
        /*
         * xoá toàn bộ dữ liệu của tất cả các kiểu
         */
        public void TruncateTable()
        {
            foreach (string name in database.Keys)
            {
                database[name].Clear();
            }
        }
    }
}
