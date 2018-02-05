using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

using WeiSha.Common;

using Song.ServiceInterfaces;
using Song.Entities;

namespace Song.Site.Manage.Sys
{
    public partial class DataClear : Extend.CustomPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        #region ���ݹ������ֵ�����
        /// <summary>
        /// ɾ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnNewsArticle_Click(object sender, EventArgs e)
        {
            try
            {
                Business.Do<IContents>().ArticleDeleteAll(-1, -1);
                new Extend.Scripts(this).Alert("�ɹ������������");
            }
            catch (Exception ex)
            {
                new Extend.Scripts(this).Alert(ex.Message);
            }
            
        }
        #endregion

        /// <summary>
        /// ���ͨѶ¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnAddressBook_Click(object sender, EventArgs e)
        {
            try
            {
                Business.Do<IAddressList>().Clear();
                Alert("�ɹ����ͨѶ¼��Ϣ��");
            }
            catch (Exception ex)
            {
                Message.ExceptionShow(ex);
            }
        }

    }
}