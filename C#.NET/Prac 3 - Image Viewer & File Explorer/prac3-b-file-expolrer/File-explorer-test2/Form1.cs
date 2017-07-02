using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_explorer_test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        //START - POPULATE TREE VIEW
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../.."); //Wherever the EXE Would be default root
            if (info.Exists) //Checks if File Exists
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode); //Calling Function to Populate the Entire Directories of it.
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,TreeNode nodeToAddTo) //Passing Subnodes
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs) //Traversing the Arrays of Sub Subnodes
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode); //Recursively Calling itself Until All nodes are explored
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        //END

        //NOW WE WILL POPULATE LISTVIEW WHEN TREEVIEW NODE IS CLICKED - START
        void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e) //On Clicking Mouse Node
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear(); //Clearing right side window
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories()) //For Directory in Right Side List View
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[] 
                {new ListViewItem.ListViewSubItem(item, "Directory"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item); //Adding Directories into List
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles()) //For File in Right Side List View
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] 
                { new ListViewItem.ListViewSubItem(item, "File"),new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item); //Adding Files into List
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //Resizing the Columns According to Name of Dir|File
        }
        //END
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick); //Handling the Event

        }
    }
}
