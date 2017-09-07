using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoryLeakTest {
    public partial class Page1 : ContentPage {
        public Page1() {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }

    internal class MainPageViewModel {
        public List<Item> Items { get; set; } = new List<Item>();
        public MainPageViewModel() {
            List<string> images = new List<string> {
                "https://images.pexels.com/photos/34950/pexels-photo.jpg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/33109/fall-autumn-red-season.jpg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/248797/pexels-photo-248797.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/207962/pexels-photo-207962.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/230629/pexels-photo-230629.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/145939/pexels-photo-145939.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/40797/wild-flowers-flowers-plant-macro-40797.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/127753/pexels-photo-127753.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/122429/leaf-nature-green-spring-122429.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/103123/pexels-photo-103123.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/206673/pexels-photo-206673.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/60628/flower-garden-blue-sky-hokkaido-japan-60628.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/68147/waterfall-thac-dray-nur-buon-me-thuot-daklak-68147.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/33688/delicate-arch-night-stars-landscape.jpg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/225203/pexels-photo-225203.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/103567/pexels-photo-103567.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/129743/pexels-photo-129743.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/258145/pexels-photo-258145.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/33045/lion-wild-africa-african.jpg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/114735/pexels-photo-114735.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://images.pexels.com/photos/306803/pexels-photo-306803.jpeg?h=350&auto=compress&cs=tinysrgb",
                "https://farm9.staticflickr.com/8625/15806486058_7005d77438.jpg",
                "https://farm5.staticflickr.com/4011/4308181244_5ac3f8239b.jpg",
                "https://farm8.staticflickr.com/7423/8729135907_79599de8d8.jpg",
                "https://farm3.staticflickr.com/2475/4058009019_ecf305f546.jpg",
                "https://farm6.staticflickr.com/5117/14045101350_113edbe20b.jpg",
                "https://farm2.staticflickr.com/1227/1116750115_b66dc3830e.jpg",
                "https://farm8.staticflickr.com/7351/16355627795_204bf423e9.jpg",
                "https://farm1.staticflickr.com/44/117598011_250aa8ffb1.jpg",
                "https://farm8.staticflickr.com/7524/15620725287_3357e9db03.jpg",
                "https://farm9.staticflickr.com/8351/8299022203_de0cb894b0.jpg",
                "https://farm4.staticflickr.com/3688/10684479284_211f2a8b0f.jpg",
                "https://farm6.staticflickr.com/5755/20725502975_0dd9b4c5f2.jpg",
                "https://farm4.staticflickr.com/3732/9308209014_ea8eac4387.jpg",
                "https://farm4.staticflickr.com/3026/3096284216_8b2e8da102.jpg",
                "https://farm3.staticflickr.com/2915/14139578975_42d87d2d00.jpg",
                "https://farm4.staticflickr.com/3900/14949063062_a92fc5426f.jpg",
                "https://farm9.staticflickr.com/8514/8349332314_e1ae376fd4.jpg",
                "https://farm3.staticflickr.com/2241/2513217764_740fdd6afa.jpg",
                "https://farm6.staticflickr.com/5083/5377978827_51d978d271.jpg",
                "https://farm4.staticflickr.com/3626/3499605313_a9d43c1c83.jpg",
                "https://farm1.staticflickr.com/16/19438696_f103861437.jpg",
                "https://farm3.staticflickr.com/2221/2243980018_d2925f3d77.jpg",
                "https://farm8.staticflickr.com/7338/8719134406_74a21b617c.jpg",
                "https://farm6.staticflickr.com/5149/5626285743_ae6a75dde7.jpg",
                "https://farm5.staticflickr.com/4105/4963731276_a10e1bd520.jpg",
                "https://farm4.staticflickr.com/3270/2814060518_6305796eb1.jpg",
                "https://farm7.staticflickr.com/6183/6123785115_2c17b85328.jpg",
                "https://farm3.staticflickr.com/2900/14398989204_59f60a05c5.jpg",
                "https://farm3.staticflickr.com/2136/1756449787_c93e6eb647.jpg",
                "https://farm4.staticflickr.com/3201/3070391067_c80fb9e942.jpg",
                "https://i.pinimg.com/564x/ef/5f/bf/ef5fbf9d999492effd33cca386f3e0e7.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/4b/29/08/4b290809887a7a234d0bbb5da078882f.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/60/78/76/607876c3f3526f5459fab1a65a203806.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/6a/33/ca/6a33caf4d96797414fa5b797f4dcedb0.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/b5/5e/e6/b55ee6062cda366655dadd2d7447ea9b.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/db/64/21/db642104c83be558340197f4aefd4b76.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/1e/fc/d2/1efcd297982cf0e88dd160a0c0fbefea.jpg",
                "https://i.pinimg.com/564x/56/27/73/562773d18d24b23f416df6e0aaf934bc.jpg",
                "https://i.pinimg.com/564x/30/6e/07/306e0761209d204fe6ad5174f54144fa.jpg",
                "https://i.pinimg.com/564x/df/b9/6f/dfb96f24e3490aee9b576b25d69f51da.jpg",
                "https://i.pinimg.com/564x/42/e5/51/42e55101f2141eeaf21c35d1150281c8.jpg",
                "https://i.pinimg.com/564x/dc/a6/db/dca6db01b5df03dd5dbe59c01171b353.jpg",
                "https://i.pinimg.com/564x/1f/73/6a/1f736ab3b9b65bff8362bb2a4c8018cd.jpg",
                "https://i.pinimg.com/564x/67/01/f0/6701f05ce03ea45474cf02c34e10c4e2.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/33/e0/06/33e006d028f887e5ad90f28545e748e5.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/cd/34/18/cd34188479162490e3c145c49a58e3c2.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/39/89/e3/3989e3fd4a123ab0bc85e20482f561a3.jpg",
                "https://i.pinimg.com/564x/7e/aa/eb/7eaaeb8acc45cf639dde4ef5ce460aec.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/aa/a7/de/aaa7def2ce782de7f96d892775e1a01a.jpg",
                "https://s-media-cache-ak0.pinimg.com/did-it/750x/24/80/0c/24800c55c0087d610dd125558d4e290d.jpg",
                "https://i.pinimg.com/564x/36/19/96/361996272bb58ab1661ea38eefb8a21a.jpg",
                "https://i.pinimg.com/564x/6a/f7/90/6af790ea9c9360481910728ecb9f7906.jpg",
                "https://i.pinimg.com/564x/ae/87/09/ae8709d5e40c2c34d988afd9a24b3632.jpg",
                "https://i.pinimg.com/564x/5c/e5/62/5ce56233119780b38d47589fba3b19b7.jpg",
                "https://i.pinimg.com/564x/06/61/a3/0661a3a9fbffd6202b9b32ea80aa0bfb.jpg",
                "https://i.pinimg.com/564x/98/bf/e1/98bfe1497c148e2e1556a953acab69d8.jpg",
                "https://i.pinimg.com/564x/70/af/39/70af39d33cfdea1fcffe43c0fba21e2f.jpg",
                "https://i.pinimg.com/564x/86/49/7b/86497b7d2ac862270e0556ad8d46e612.jpg",
                "https://i.pinimg.com/564x/28/05/75/28057514dccbfab9d5aca03b87954aee.jpg",
                "http://www.artenocorpo.com/sites/www.artenocorpo.com/files/imagecache/primera/Tatuagens-de-espelhos-1.jpg",
                "https://i.pinimg.com/564x/58/b6/ce/58b6ce1db921bfafc7118987d1c3f162.jpg",
            };
            foreach(string image in images) {
                Items.Add(new Item(image));
            }
        }
    }

    public class Item {
        public Item(string link) {
            Url = link;
        }
        public string Url { get; set; } = "";
    }
}
