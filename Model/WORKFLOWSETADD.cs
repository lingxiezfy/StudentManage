using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    [Serializable]
    public partial class  WORKFLOWSETADD
    {
        public WORKFLOWSETADD()
		{}
        #region Model
        private int _setno;
        private string _nodename;
        private string _workflowname;
        private int _nodeorder;
        private DateTime? _begintime;
        private DateTime? _endtime;

        /// <summary>
        /// 
        /// </summary>
        public int SETNO
        {
            set { _setno = value; }
            get { return _setno; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NODENAME
        {
            set { _nodename = value; }
            get { return _nodename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WORKFLOWNAME
        {
            set { _workflowname = value; }
            get { return _workflowname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int NODEORDER
        {
            set { _nodeorder = value; }
            get { return _nodeorder; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ?BEGINTIME
        {
            set { _begintime = value; }
            get { return _begintime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ?ENDTIME
        {
            set { _endtime = value; }
            get { return _endtime; }
        }
        #endregion Model
    }
}
