using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ej_LlenarDDL
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadComboArtist();
            }
        }

        private void LoadComboArtist()
        {
            //ddl_Artist.DataSource = ChinookDAL.GellAllArtist();
            ddl_Artist.DataTextField = "Name";
            ddl_Artist.DataValueField = "ArtistId";
            ddl_Artist.DataBind();
            if (ddl_Artist.Items.Count != 0)
                {
                int ArtistId = Convert.ToInt32(ddl_Artist.SelectedValue);
                LoadComboAlbum(ArtistId);
                }
            else
                {
                //ddl_Album.Items.Clear();
                //ddl_Track.Items.Clear();
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
                }
        }

        protected void ddl_Artist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int artistaId = Convert.ToInt32(ddl_Artist.SelectedValue);
            LoadComboAlbum(artistaId);
        }

        private void LoadComboAlbum(int ArtistId)
            {
                //ddl_Album.DataSource = ChinookDAL.GellAlbumByArtist(ArtistId);
                ddl_Album.DataTextField = "Title";
                ddl_Album.DataValueField = "AlbumId";
                ddl_Album.DataBind();
                if (ddl_Album.Items.Count != 0)
                    {
                        int AlbumId = Convert.ToInt32(ddl_Album.SelectedValue);
                        LoadComboTrack(AlbumId);
                    }
                else
                    {
                        ddl_Track.Items.Clear();
                        //dvCustomer.DataSource = null;
                        //dvCustomer.DataBind();
                    }
            }

        protected void ddl_Album_SelectedIndexChanged(object sender, EventArgs e)
        {
            int albumId = Convert.ToInt32(ddl_Album.SelectedValue);
            LoadComboTrack(albumId);
        }

        private void LoadComboTrack(int AlbumId)
        {
           // ddl_Track.DataSource = ChinookDAL.GellTrackByAlbum(AlbumId);
            ddl_Track.DataTextField = "Name";
            ddl_Track.DataValueField = "TrackId";
            ddl_Track.DataBind();
            if (ddl_Track.Items.Count != 0)
                {
                    int TrackId = Convert.ToInt32(ddl_Track.SelectedValue);
                    LoadGridViewCustomer(TrackId);
                }
            else
            {
                //dvCustomer.DataSource = null;
                //dvCustomer.DataBind();
            }
        }

        protected void ddl_Track_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trackId = Convert.ToInt32(ddl_Track.SelectedValue);
            LoadGridViewCustomer(trackId);
        }

        private void LoadGridViewCustomer(int TrackId)
        {
            //dvCustomer.DataSource = ChinookDAL.GellCustomerByTrack(TrackId);
            //dvCustomer.DataBind();
        }
    }
}
