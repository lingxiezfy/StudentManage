using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    [Serializable]
    public partial class NODEMATERIALSADD
    {
        public NODEMATERIALSADD()
        { }
        #region Model
        private int _nodematerialsno;
        private string _nodename;
        private string _materialname;
        private string _name;
        private DateTime? _begintime;
        private DateTime? _endtime;
        private string _memo;

        /// <summary>
        /// 
        /// </summary>
        public int NODEMATERIALSNO
        {
            set { _nodematerialsno = value; }
            get { return _nodematerialsno; }
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
        public string MATERIALNAME
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? BEGINTIME
        {
            set { _begintime = value; }
            get { return _begintime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ENDTIME
        {
            set { _endtime = value; }
            get { return _endtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MEMO
        {
            set { _memo = value; }
            get { return _memo; }
        }
        #endregion Model
    }
}
