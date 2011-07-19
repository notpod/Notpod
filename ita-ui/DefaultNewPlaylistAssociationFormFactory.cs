using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.UI
{
    public class DefaultNewPlaylistAssociationFormFactory : INewPlaylistAssociationFormFactory
    {
        private ModelRepository modelRepository;

        public ModelRepository ModelRepository
        {
            set { this.modelRepository = value; }
        }

        public NewPlaylistAssociationForm NewInstance()
        {
            NewPlaylistAssociationForm form = new NewPlaylistAssociationForm();
            form.Model = modelRepository;
            return form;
        }
    }
}
