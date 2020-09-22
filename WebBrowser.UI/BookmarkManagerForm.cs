﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.logic;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            //get all bookmark items
            var items = BookmarkManager.GetBookmarkItems();
            listBox1.Items.Clear(); //listbox of bookmark form

            //Display in listbox
            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }
    }
}
