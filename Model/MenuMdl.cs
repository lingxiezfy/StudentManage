namespace Student.Model
{
    using System;
    using System.Runtime.CompilerServices;

    public class MenuMdl
    {
        
        private string _Para;
        private string _TBar;
        private string _Type;
        private bool   m_bLeaf;
        private int    m_iID;
        private string m_sCaption;
        private string m_sCode;
        private string m_sImg;
        private string m_sTip;
        private string m_sUrl;

        public string Caption
        {
            get
            {
                return this.m_sCaption;
            }
            set
            {
                this.m_sCaption = value;
            }
        }

        public string Code
        {
            get
            {
                return this.m_sCode;
            }
            set
            {
                this.m_sCode = value;
            }
        }

        public int ID
        {
            get
            {
                return this.m_iID;
            }
            set
            {
                this.m_iID = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return this.m_sImg;
            }
            set
            {
                this.m_sImg = value;
            }
        }

        public bool Leaf
        {
            get
            {
                return this.m_bLeaf;
            }
            set
            {
                this.m_bLeaf = value;
            }
        }

        public string Para
        {
            
            get
            {
                return this._Para;
            }
            
            set
            {
                this._Para = value;
            }
        }

        public string TBar
        {
            
            get
            {
                return this._TBar;
            }
            
            set
            {
                this._TBar = value;
            }
        }

        public string Tip
        {
            get
            {
                return this.m_sTip;
            }
            set
            {
                this.m_sTip = value;
            }
        }

        public string Type
        {
            
            get
            {
                return this._Type;
            }
            
            set
            {
                this._Type = value;
            }
        }

        public string Url
        {
            get
            {
                return this.m_sUrl;
            }
            set
            {
                this.m_sUrl = value;
            }
        }
    }
}

