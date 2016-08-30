using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JsonDiffPatch;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using Formatting = Newtonsoft.Json.Formatting;

namespace SirenDotNet.Tests
{
    public class JsonSerializationTests
    {
        [Test]
        public void CanDeserializeAndSerializeCorrectly()
        {
            //Given json containing a complex siren document
            var jsonDoc = JToken.Parse(json);
            //When that document is deserialized
            var sirenDoc = jsonDoc.ToObject<Entity>();
            //And then re-serialized
            var reserialized = JToken.FromObject(sirenDoc, new JsonSerializer()
            {
               ContractResolver = new CamelCasePropertyNamesContractResolver(),
               NullValueHandling = NullValueHandling.Ignore
            });
            reserialized = JToken.Parse(reserialized.ToString());
            //Then the document json is equivalent
            Assert.True(JToken.DeepEquals(jsonDoc, reserialized));
        }

        string json = @"{
  ""class"": [
    ""root"",
    ""subreddit"",
    ""pagination""
  ],
  ""entities"": [
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 6115,
        ""subreddit"": ""gaming"",
        ""comments"": 496,
        ""submitted"": ""2016-08-08T12:07:30Z"",
        ""authorName"": ""haydnwolfie"",
        ""domain"": ""imgur.com"",
        ""linkFlairText"": null,
        ""url"": ""http://imgur.com/a/RfO2m"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/LnF83xO_8QKN47olwqn2LH-C2ZNiRqyEXETlvOglo_s.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/gaming/comments/4wpt5o/i_tried_to_make_a_thing_in_gta/""
        }
      ],
      ""title"": ""I tried to make a thing in GTA""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 4475,
        ""subreddit"": ""todayilearned"",
        ""comments"": 340,
        ""submitted"": ""2016-08-08T12:47:25Z"",
        ""authorName"": ""Nomanila"",
        ""domain"": ""en.wikipedia.org"",
        ""linkFlairText"": null,
        ""url"": ""https://en.wikipedia.org/wiki/Vedius_Pollio"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/eDDWY2WFK06wVW2YL8655CbW-pglq5g_rLIeHLHeqCY.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/todayilearned/comments/4wpz3q/til_that_roman_emperor_augustus_witnessed_a_man/""
        }
      ],
      ""title"": ""TIL that Roman Emperor Augustus witnessed a man attempt to feed a slave to lamprey eels as a punishment for breaking a cup. Augustus freed the slave and had the rest of the man's cups broken.""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 6143,
        ""subreddit"": ""gifs"",
        ""comments"": 813,
        ""submitted"": ""2016-08-08T10:58:23Z"",
        ""authorName"": ""sivribiber"",
        ""domain"": ""i.redd.it"",
        ""linkFlairText"": null,
        ""url"": ""https://i.redd.it/4vgs3dqc35ex.gif"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/5qXEdST29T45RJISMfA9UBeZztHK-KXvUyQWI54k7kQ.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/gifs/comments/4wpkxa/70_hours_of_dots/""
        }
      ],
      ""title"": ""70 Hours of Dots""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3582,
        ""subreddit"": ""space"",
        ""comments"": 243,
        ""submitted"": ""2016-08-08T13:01:09Z"",
        ""authorName"": ""HavoKTheory"",
        ""domain"": ""gfycat.com"",
        ""linkFlairText"": null,
        ""url"": ""https://gfycat.com/FlimsyWellwornAsiaticwildass"",
        ""thumbnail"": ""http://a.thumbs.redditmedia.com/dG_ROI28Wu5mnHJv1bSkIf3uinO0k1p6QBNaEeHLwX4.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/space/comments/4wq15s/nasas_new_high_dynamic_camera_records_sls_rocket/""
        }
      ],
      ""title"": ""NASA’s new High Dynamic Camera Records SLS Rocket Test""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3262,
        ""subreddit"": ""news"",
        ""comments"": 265,
        ""submitted"": ""2016-08-08T13:05:50Z"",
        ""authorName"": ""jaykirsch"",
        ""domain"": ""bbc.co.uk"",
        ""linkFlairText"": null
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/news/comments/4wq1xv/tesla_car_drives_owner_to_hospital_after_he/""
        }
      ],
      ""title"": ""Tesla car drives owner to hospital after he suffers pulmonary embolism""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 2487,
        ""subreddit"": ""aww"",
        ""comments"": 75,
        ""submitted"": ""2016-08-08T14:26:48Z"",
        ""authorName"": ""Shady_Slim"",
        ""domain"": ""i.imgur.com"",
        ""linkFlairText"": null,
        ""url"": ""http://i.imgur.com/7zvzC0m.gifv"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/N_0p4o7LN81pt7QoLeQJmiRDeDF2puxfZ1_Mh_EQxZg.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/aww/comments/4wqeb4/this_dog_was_born_to_dive_into_swimming_pools/""
        }
      ],
      ""title"": ""This dog was born to dive into swimming pools""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 6160,
        ""subreddit"": ""worldnews"",
        ""comments"": 2131,
        ""submitted"": ""2016-08-08T09:19:35Z"",
        ""authorName"": ""NinjaDiscoJesus"",
        ""domain"": ""bbc.com"",
        ""linkFlairText"": ""Incl. intl. flights""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/worldnews/comments/4wpa4x/delta_airlines_says_all_flights_suspended_due_to/""
        }
      ],
      ""title"": ""Delta airlines says all flights suspended \""due to system outage nationwide\""""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 4154,
        ""subreddit"": ""Jokes"",
        ""comments"": 298,
        ""submitted"": ""2016-08-08T11:22:53Z"",
        ""authorName"": ""Zsolty0497"",
        ""domain"": ""self.Jokes"",
        ""linkFlairText"": ""Politics""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/Jokes/comments/4wpnme/george_bush_dies_and_goes_to_hell/""
        }
      ],
      ""title"": ""George Bush dies and goes to hell""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 4908,
        ""subreddit"": ""mildlyinteresting"",
        ""comments"": 424,
        ""submitted"": ""2016-08-08T10:09:17Z"",
        ""authorName"": ""oxfordattic"",
        ""domain"": ""i.redd.it"",
        ""linkFlairText"": null,
        ""url"": ""https://i.redd.it/0kq34admu4ex.jpg"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/uyN9fGZRoSot8UHciMCLjfyhn3GN3lvpE5Mt0oFa4EU.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/mildlyinteresting/comments/4wpfl7/there_are_head_rests_above_the_urinals_in_this_bar/""
        }
      ],
      ""title"": ""There are head rests above the urinals in this bar.""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3613,
        ""subreddit"": ""funny"",
        ""comments"": 268,
        ""submitted"": ""2016-08-08T11:50:08Z"",
        ""authorName"": ""blossomsblooming67"",
        ""domain"": ""i.redd.it"",
        ""linkFlairText"": null,
        ""url"": ""https://i.redd.it/n85shd4mc5ex.png"",
        ""thumbnail"": ""http://a.thumbs.redditmedia.com/PlOLGxp1jAQqZ_ucwdqz0UjZipbSSjSqs1xdA92hZO0.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/funny/comments/4wpqvk/dc_marvel/""
        }
      ],
      ""title"": ""DC &amp; Marvel""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 2851,
        ""subreddit"": ""Futurology"",
        ""comments"": 764,
        ""submitted"": ""2016-08-08T12:35:57Z"",
        ""authorName"": ""lnfinity"",
        ""domain"": ""sputniknews.com"",
        ""linkFlairText"": ""article"",
        ""url"": ""http://sputniknews.com/art_living/20160806/1044006015/food-production-meat.html"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/aXiw5q9LhFOxFRBpbMV7uEwClM6L6ZBpoOdxMlbZPBY.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/Futurology/comments/4wpxbo/how_to_feed_ten_billion_labmade_clean_meat/""
        }
      ],
      ""title"": ""How to Feed Ten Billion: Lab-Made 'Clean Meat' Burgers are Future of Food""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3232,
        ""subreddit"": ""UpliftingNews"",
        ""comments"": 209,
        ""submitted"": ""2016-08-08T11:37:26Z"",
        ""authorName"": ""speckz"",
        ""domain"": ""mirror.co.uk"",
        ""linkFlairText"": null,
        ""url"": ""http://www.mirror.co.uk/news/world-news/street-food-chef-speaks-amazement-8561995"",
        ""thumbnail"": ""http://a.thumbs.redditmedia.com/IKR6S1h_hQ0y3fmivLo7lvfcAmIO_iJ4tmX5WN7wST0.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/UpliftingNews/comments/4wppc6/street_food_chef_stunned_after_his_hawker_stall/""
        }
      ],
      ""title"": ""Street food chef stunned after his hawker stall becomes world's first to earn Michelin star""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3366,
        ""subreddit"": ""AskReddit"",
        ""comments"": 5979,
        ""submitted"": ""2016-08-08T10:59:17Z"",
        ""authorName"": ""versatileRealist"",
        ""domain"": ""self.AskReddit"",
        ""linkFlairText"": null
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/AskReddit/comments/4wpl0i/whats_a_big_industry_secret_that_isnt_supposed_to/""
        }
      ],
      ""title"": ""Whats a big industry secret that isn't supposed to be known by the general public?""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 6499,
        ""subreddit"": ""pics"",
        ""comments"": 1544,
        ""submitted"": ""2016-08-08T05:38:09Z"",
        ""authorName"": ""Ghawblin"",
        ""domain"": ""imgur.com"",
        ""linkFlairText"": null,
        ""url"": ""http://imgur.com/k5GCYi1"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/IwLcrUHrSajt2EcALM5Hr19li-plXGNDE0vQ-kmvQBs.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/pics/comments/4wonts/my_coworker_had_this_picture_taken_at_a_dodge/""
        }
      ],
      ""title"": ""My coworker had this picture taken at a Dodge Charger meet-up he helped organize.""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3947,
        ""subreddit"": ""Documentaries"",
        ""comments"": 421,
        ""submitted"": ""2016-08-08T08:12:03Z"",
        ""authorName"": ""jxang"",
        ""domain"": ""youtu.be"",
        ""linkFlairText"": ""Music"",
        ""url"": ""http://youtu.be/jEu-ESPmqs8"",
        ""thumbnail"": ""http://a.thumbs.redditmedia.com/ETE0grbF9qvVgzPBNRhWaTOgH4fwKBHSEYyBInbusy8.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/Documentaries/comments/4wp3k4/hans_zimmer_revealed_2015_an_amazing_documentary/""
        }
      ],
      ""title"": ""Hans Zimmer Revealed (2015) - An amazing documentary on the man behind film's greatest soundtracks. Some of the most beautiful music you will ever hear.""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 6043,
        ""subreddit"": ""videos"",
        ""comments"": 1621,
        ""submitted"": ""2016-08-08T05:42:24Z"",
        ""authorName"": ""McKFC"",
        ""domain"": ""youtu.be"",
        ""linkFlairText"": null,
        ""url"": ""https://youtu.be/cZDn0U0w78k"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/R5eTVdhiOOECqyOVlVO4GuRh1CGuKhqpVIfsGWDEKCs.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/videos/comments/4woo9w/the_best_piece_of_olympic_broadcasting_ever_aired/""
        }
      ],
      ""title"": ""The best piece of Olympic broadcasting ever aired""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 1440,
        ""subreddit"": ""science"",
        ""comments"": 101,
        ""submitted"": ""2016-08-08T12:14:39Z"",
        ""authorName"": ""Adriano-Lameira"",
        ""domain"": ""self.science"",
        ""linkFlairText"": ""Ape Communication"",
        ""url"": ""https://www.reddit.com/r/science/comments/4wpu6f/science_ama_series_im_adriano_lameira_postdoc/"",
        ""thumbnail"": ""/self""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/science/comments/4wpu6f/science_ama_series_im_adriano_lameira_postdoc/""
        }
      ],
      ""title"": ""Science AMA Series: \""I’m Adriano Lameira, post-doc research fellow at the Durham University, UK. On the 8th of August, I will be here to chat about our recent study with Rocky, who has broken through the glass ceiling of the traditional theory of speech evolution. AMA!""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3112,
        ""subreddit"": ""nottheonion"",
        ""comments"": 1027,
        ""submitted"": ""2016-08-08T05:44:58Z"",
        ""authorName"": ""theargamanknight"",
        ""domain"": ""timesofisrael.com"",
        ""linkFlairText"": null,
        ""url"": ""http://www.timesofisrael.com/swedish-church-to-drop-bibles-in-is-controlled-areas/"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/fZ3-p0j9sodODSh4E4nXKRRuyzD0J_kPdj8u_CKbnOw.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/nottheonion/comments/4woojg/swedish_church_to_drop_bibles_in_iscontrolled/""
        }
      ],
      ""title"": ""Swedish church to drop Bibles in IS-controlled areas""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 5066,
        ""subreddit"": ""movies"",
        ""comments"": 4044,
        ""submitted"": ""2016-08-08T02:43:51Z"",
        ""authorName"": ""Karmas-Camera"",
        ""domain"": ""huffingtonpost.com"",
        ""linkFlairText"": ""News"",
        ""url"": ""http://www.huffingtonpost.com/entry/why-ghostbusters-director-would-never-reboot-another-classic-movie_us_57a2575ae4b0e1aac9149f7a"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/buHS29r-CfylfkKLjASnWHXIf8q49Nh3dnMeMd5k4Is.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/movies/comments/4wo30a/ghostbusters_director_says_he_wont_reboot_another/""
        }
      ],
      ""title"": ""'Ghostbusters' Director Says He Won't Reboot Another Classic Movie""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 4489,
        ""subreddit"": ""olympics"",
        ""comments"": 1045,
        ""submitted"": ""2016-08-08T02:56:53Z"",
        ""authorName"": ""flippityfloppityfloo"",
        ""domain"": ""self.olympics"",
        ""linkFlairText"": null,
        ""url"": ""https://www.reddit.com/r/olympics/comments/4wo4m6/team_usa_wins_the_mens_4x100_freestyle_phelps/"",
        ""thumbnail"": ""/self""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/olympics/comments/4wo4m6/team_usa_wins_the_mens_4x100_freestyle_phelps/""
        }
      ],
      ""title"": ""Team USA wins the Men's 4x100 Freestyle; Phelps wins gold medal #19!!!""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 4494,
        ""subreddit"": ""EarthPorn"",
        ""comments"": 131,
        ""submitted"": ""2016-08-08T02:44:19Z"",
        ""authorName"": ""strawberrynesquick"",
        ""domain"": ""i.reddituploads.com"",
        ""linkFlairText"": null,
        ""url"": ""https://i.reddituploads.com/36b4556636d0424f9611b2d43ca279b3?fit=max&amp;h=1536&amp;w=1536&amp;s=537beece79d1eb79c091f9517c605e7a"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/qMvdodgzfAfGZJZEeTKFfpJO_fa48YC8nd1w-XCCO_U.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/EarthPorn/comments/4wo32a/oregon_coast_oc_3264x2448/""
        }
      ],
      ""title"": ""Oregon Coast [OC] [3264x2448]""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 1280,
        ""subreddit"": ""gadgets"",
        ""comments"": 77,
        ""submitted"": ""2016-08-08T08:38:02Z"",
        ""authorName"": ""BeardedBalkan"",
        ""domain"": ""geek.com"",
        ""linkFlairText"": ""Misc"",
        ""url"": ""http://www.geek.com/science/brixo-is-lego-with-added-electricity-and-sensors-1661343/"",
        ""thumbnail"": ""http://a.thumbs.redditmedia.com/2DPtBYLioOYAgnFIfT9g2QE1rhHv8Hflsaxn_aO4ZH4.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/gadgets/comments/4wp5zv/brixo_is_lego_with_added_electricity_and_sensors/""
        }
      ],
      ""title"": ""Brixo is Lego with added electricity and sensors""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 497,
        ""subreddit"": ""OldSchoolCool"",
        ""comments"": 66,
        ""submitted"": ""2016-08-08T13:34:28Z"",
        ""authorName"": ""UberStone"",
        ""domain"": ""i.redd.it"",
        ""linkFlairText"": null,
        ""url"": ""https://i.redd.it/wwkp4kuhu5ex.jpg"",
        ""thumbnail"": ""http://a.thumbs.redditmedia.com/4aqcQso_AVqSAX9zm1uhTy3E2R-hz0Q2WwyA0EeiJI0.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/OldSchoolCool/comments/4wq637/ayyyyyyy_my_wife_used_to_date_the_fonz_henry/""
        }
      ],
      ""title"": ""Ayyyyyyy. My wife used to date \""The Fonz\"" (Henry Winkler) in the late 70's""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 497,
        ""subreddit"": ""television"",
        ""comments"": 122,
        ""submitted"": ""2016-08-08T13:31:57Z"",
        ""authorName"": ""BlobDude"",
        ""domain"": ""variety.com"",
        ""linkFlairText"": null,
        ""url"": ""http://variety.com/2016/digital/news/hulu-free-streaming-end-yahoo-1201832578/"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/xYlb5of5VFbhV8Q2e2bkoZ1iP8o8GlPoczvasPPKm8g.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/television/comments/4wq5oh/hulu_to_end_free_streaming_service/""
        }
      ],
      ""title"": ""Hulu to End Free Streaming Service""
    },
    {
      ""class"": [
        ""post""
      ],
      ""rel"": [
        ""post""
      ],
      ""properties"": {
        ""score"": 3423,
        ""subreddit"": ""DIY"",
        ""comments"": 204,
        ""submitted"": ""2016-08-08T02:46:09Z"",
        ""authorName"": ""ejchristian86"",
        ""domain"": ""imgur.com"",
        ""linkFlairText"": null,
        ""url"": ""http://imgur.com/a/Pfcyd"",
        ""thumbnail"": ""http://b.thumbs.redditmedia.com/pqcGOhi5JjroRxWND_wvI4DwCmxCo1kcUbPvsqD7Z6g.jpg""
      },
      ""links"": [
        {
          ""rel"": [
            ""self""
          ],
          ""href"": ""/r/DIY/comments/4wo3b0/painted_a_disneyinspired_castle_mural_for_my/""
        }
      ],
      ""title"": ""Painted a Disney-inspired Castle mural for my incoming daughter!""
    }
  ],
  ""links"": [
    {
      ""rel"": [
        ""next""
      ],
      ""class"": [
        ""pagination""
      ],
      ""href"": ""?count=25"",
      ""title"": ""Next""
    }
  ],
  ""actions"": [
    {
      ""name"": ""search"",
      ""method"": ""GET"",
      ""href"": ""/search"",
      ""title"": ""Search"",
      ""type"": ""application/x-www-form-urlencoded"",
      ""fields"": [
        {
          ""name"": ""q"",
          ""type"": ""text""
        }
      ]
    }
  ]
}";
    }
}
