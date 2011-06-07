using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEditable.Models
{
    public class DataRepository
    {

        public static IList<Company> CompanyData = null;
        public static IList<Company> GetCompanies()
        {
            if (CompanyData == null)
            {
                CompanyData = new List<Company>();
                CompanyData.Add(new Company() { Name = "Emkay Entertainments", Address = "Nobel House, Regent Centre", Town = "Lothian" });
                CompanyData.Add(new Company() { Name = "The Empire", Address = "Milton Keynes Leisure Plaza", Town = "Buckinghamshire" });
                CompanyData.Add(new Company() { Name = "Asadul Ltd", Address = "Hophouse", Town = "Essex" });
                CompanyData.Add(new Company() { Name = "Gargamel", Address = "", Town = "" });
                CompanyData.Add(new Company() { Name = "Ashley Mark Publishing Company", Address = "1-2 Vance Court", Town = "Tyne & Wear" });
                CompanyData.Add(new Company() { Name = "MuchMoreMusic Studios", Address = "Unit 29", Town = "London" });
                CompanyData.Add(new Company() { Name = "Victoria Music Ltd", Address = "Unit 215", Town = "London" });
                CompanyData.Add(new Company() { Name = "Abacus Agent", Address = "Regent Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "Atomic", Address = "133 Longacre", Town = "London" });
                CompanyData.Add(new Company() { Name = "Pyramid Posters", Address = "The Works", Town = "Leicester" });
                CompanyData.Add(new Company() { Name = "Kingston Smith Financial Services Ltd", Address = "105 St Peter's Street", Town = "Herts" });
                CompanyData.Add(new Company() { Name = "Garrett Axford PR", Address = "Harbour House", Town = "West Sussex" });
                CompanyData.Add(new Company() { Name = "Derek Boulton Management", Address = "76 Carlisle Mansions", Town = "London" });
                CompanyData.Add(new Company() { Name = "Total Concept Management (TCM)", Address = "PO Box 128", Town = "West Yorks" });
                CompanyData.Add(new Company() { Name = "Billy Russell Management", Address = "Binny Estate", Town = "Edinburgh" });
                CompanyData.Add(new Company() { Name = "Stage Audio Services", Address = "Unit 2", Town = "Stourbridge" });
                CompanyData.Add(new Company() { Name = "Windsong International", Address = "Heather Court", Town = "Kent" });
                CompanyData.Add(new Company() { Name = "Vivante Music Ltd", Address = "32 The Netherlands", Town = "Surrey" });
                CompanyData.Add(new Company() { Name = "Way to Blue", Address = "First Floor", Town = "London" });
                CompanyData.Add(new Company() { Name = "Glasgow City Halls", Address = "32 Albion Street", Town = "Lanarkshire" });
                CompanyData.Add(new Company() { Name = "The List", Address = "14 High St", Town = "Edinburgh" });
                CompanyData.Add(new Company() { Name = "Wilkinson Turner King", Address = "10A London Road", Town = "Cheshire" });
                CompanyData.Add(new Company() { Name = "GSC Solicitors", Address = "31-32 Ely Place", Town = "London" });
                CompanyData.Add(new Company() { Name = "Vanessa Music Co", Address = "35 Tower Way", Town = "Devon" });
                CompanyData.Add(new Company() { Name = "Regent Records", Address = "PO Box 528", Town = "West Midlands" });
                CompanyData.Add(new Company() { Name = "BBC Radio Lancashire", Address = "20-26 Darwen St", Town = "Blackburn" });
                CompanyData.Add(new Company() { Name = "The Citadel Arts Centre", Address = "Waterloo Street", Town = "Merseyside" });
                CompanyData.Add(new Company() { Name = "Villa Audio Ltd", Address = "Baileys Yard", Town = "Essex" });
                CompanyData.Add(new Company() { Name = "cave 3", Address = "", Town = "" });
                CompanyData.Add(new Company() { Name = "Idle Eyes Printshop", Address = "81 Sheen Court", Town = "Surrey" });
                CompanyData.Add(new Company() { Name = "Miggins Music (UK)", Address = "33 Mandarin Place", Town = "Oxon" });
                CompanyData.Add(new Company() { Name = "Magic 999", Address = "St Paul's Square", Town = "Lancashire" });
                CompanyData.Add(new Company() { Name = "Delga Group", Address = "Seaplane House, Riverside Est.", Town = "Kent" });
                CompanyData.Add(new Company() { Name = "Zane Music", Address = "162 Castle Hill", Town = "Berkshire" });
                CompanyData.Add(new Company() { Name = "Universal Music Operations", Address = "Chippenham Drive", Town = "Milton Keynes" });
                CompanyData.Add(new Company() { Name = "Gotham Records", Address = "PO Box 6003", Town = "Birmingham" });
                CompanyData.Add(new Company() { Name = "Timbuktu Music Ltd", Address = "99C Talbot Road", Town = "London" });
                CompanyData.Add(new Company() { Name = "Online Music", Address = "Unit 18, Croydon House", Town = "Surrey" });
                CompanyData.Add(new Company() { Name = "Irish Music Magazine", Address = "11 Clare St", Town = "Ireland" });
                CompanyData.Add(new Company() { Name = "Savoy Records", Address = "PO Box 271", Town = "Surrey" });
                CompanyData.Add(new Company() { Name = "Temple Studios", Address = "97A Kenilworth Road", Town = "Middlesex" });
                CompanyData.Add(new Company() { Name = "Gravity Shack Studio", Address = "Unit 3 ", Town = "London" });
                CompanyData.Add(new Company() { Name = "Dovehouse Records", Address = "Crabtree Cottage", Town = "Oxon" });
                CompanyData.Add(new Company() { Name = "Citysounds Ltd", Address = "5 Kirby Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "Revolver Music Publishing", Address = "152 Goldthorn Hill", Town = "West Midlands" });
                CompanyData.Add(new Company() { Name = "Jug Of Ale", Address = "43 Alcester Road", Town = "West Midlands" });
                CompanyData.Add(new Company() { Name = "Isles FM 103", Address = "PO Box 333", Town = "Western Isles" });
                CompanyData.Add(new Company() { Name = "Headscope", Address = "Headrest", Town = "East Sussex" });
                CompanyData.Add(new Company() { Name = "Universal Music Ireland", Address = "9 Whitefriars", Town = "Ireland" });
                CompanyData.Add(new Company() { Name = "Zander Exports", Address = "34 Sapcote Trading Centre", Town = "London" });
                CompanyData.Add(new Company() { Name = "Midem (UK)", Address = "Walmar House", Town = "London" });
                CompanyData.Add(new Company() { Name = "La Rocka Studios", Address = "Post Mark House", Town = "London" });
                CompanyData.Add(new Company() { Name = "Warner Home DVD", Address = "Warner House", Town = "London" });
                CompanyData.Add(new Company() { Name = "Music Room", Address = "The Old Library", Town = "London" });
                CompanyData.Add(new Company() { Name = "Blue Planet", Address = "96 York Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "Dream 107.7FM", Address = "Cater House", Town = "Chelmsford" });
                CompanyData.Add(new Company() { Name = "Moneypenny Agency", Address = "The Stables, Westwood House", Town = "East Yorks" });
                CompanyData.Add(new Company() { Name = "Artsun", Address = "18 Sparkle Street", Town = "Manchester" });
                CompanyData.Add(new Company() { Name = "Clyde 2", Address = "Clydebank Business Park", Town = "Glasgow" });
                CompanyData.Add(new Company() { Name = "9PR", Address = "65-69 White Lion Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "River Studio's", Address = "3 Grange Yard", Town = "London" });
                CompanyData.Add(new Company() { Name = "Start Entertainments Ltd", Address = "3 Warmair House", Town = "Middx" });
                CompanyData.Add(new Company() { Name = "Vinyl Tap Mail Order Music", Address = "1 Minerva Works", Town = "West Yorkshire" });
                CompanyData.Add(new Company() { Name = "Passion Music", Address = "20 Blyth  Rd", Town = "Middlesex" });
                CompanyData.Add(new Company() { Name = "SuperVision Management", Address = "Zeppelin Building", Town = "London" });
                CompanyData.Add(new Company() { Name = "Lite FM", Address = "2nd Floor", Town = "Peterborough" });
                CompanyData.Add(new Company() { Name = "ISIS Duplicating Company", Address = "Sales & Production", Town = "Merseyside" });
                CompanyData.Add(new Company() { Name = "Vanderbeek & Imrie Ltd", Address = "15 Marvig", Town = "Scotland" });
                CompanyData.Add(new Company() { Name = "Glamorgan University", Address = "Student Union", Town = "Mid Glamorgan" });
                CompanyData.Add(new Company() { Name = "Web User", Address = "IPC Media", Town = "London " });
                CompanyData.Add(new Company() { Name = "Farnborough Recreation Centre", Address = "1 Westmead", Town = "Hampshire" });
                CompanyData.Add(new Company() { Name = "Robert Owens/Musical Directions", Address = "352A Kilburn Lane", Town = "London" });
                CompanyData.Add(new Company() { Name = "Magick Eye Records", Address = "PO Box 3037", Town = "Berks" });
                CompanyData.Add(new Company() { Name = "Alexandra Theatre", Address = "Station Street", Town = "West Midlands" });
                CompanyData.Add(new Company() { Name = "Keda Records", Address = "The Sight And Sound Centre", Town = "Middlesex" });
                CompanyData.Add(new Company() { Name = "Independiente Ltd", Address = "The Drill Hall", Town = "London" });
                CompanyData.Add(new Company() { Name = "Shurwood Management", Address = "Tote Hill Cottage", Town = "West Sussex" });
                CompanyData.Add(new Company() { Name = "Fury Records", Address = "PO Box 52", Town = "Kent" });
                CompanyData.Add(new Company() { Name = "Northumbria University", Address = "Union Building", Town = "Newcastle upon Tyne" });
                CompanyData.Add(new Company() { Name = "Pop Muzik", Address = "Haslemere", Town = "W. Sussex" });
                CompanyData.Add(new Company() { Name = "Jonsongs Music", Address = "3 Farrers Place", Town = "Surrey" });
                CompanyData.Add(new Company() { Name = "Hermana PR", Address = "Unit 244, Bon Marche Centre", Town = "London" });
                CompanyData.Add(new Company() { Name = "Sugarcane Music", Address = "32 Blackmore Avenue", Town = "Middlesex" });
                CompanyData.Add(new Company() { Name = "JFM Records", Address = "11 Alexander House", Town = "London" });
                CompanyData.Add(new Company() { Name = "Black Market Records", Address = "25 D'Arblay Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "Float Your Boat Productions", Address = "5 Ralphs Retreat", Town = "Bucks" });
                CompanyData.Add(new Company() { Name = "Creation Management", Address = "2 Berkley Grove", Town = "London" });
                CompanyData.Add(new Company() { Name = "Bryter Music", Address = "Marlinspike Hall", Town = "Suffolk" });
                CompanyData.Add(new Company() { Name = "The Headline Agency", Address = "39 Churchfields", Town = "Ireland" });
                CompanyData.Add(new Company() { Name = "MP Promotions", Address = "13 Greave", Town = "Cheshire" });
                CompanyData.Add(new Company() { Name = "Modo Production Ltd", Address = "Ground Floor", Town = "London" });
                CompanyData.Add(new Company() { Name = "Nomadic Music", Address = "Unit 18", Town = "London" });
                CompanyData.Add(new Company() { Name = "Reverb Records Ltd", Address = "Reverb House", Town = "London" });
                CompanyData.Add(new Company() { Name = "SIBC", Address = "Market Street", Town = "Lerwick" });
                CompanyData.Add(new Company() { Name = "Marken Time Critical Express", Address = "Unit 2", Town = "Isleworth" });
                CompanyData.Add(new Company() { Name = "102.2 Smooth FM", Address = "26-27 Castlereagh Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "Chesterfield Arts Centre", Address = "Chesterfield College", Town = "Derbyshire" });
                CompanyData.Add(new Company() { Name = "The National Indoor Arena", Address = "King Edward's Road", Town = "West Midlands" });
                CompanyData.Add(new Company() { Name = "Salisbury City Hall", Address = "Malthouse Lane", Town = "Wiltshire" });
                CompanyData.Add(new Company() { Name = "Minder Music", Address = "", Town = "" });
            }
            return CompanyData;
        }

        public static IList<Town> townData = null;
        public static IList<Town> getTown()
        {
            if (townData == null)
            {
                townData = new List<Town>();
                townData.Add(new Town() { Name = "Derbyshire" });
                townData.Add(new Town() { Name = "London" });
                townData.Add(new Town() { Name = "West Midlands" });
                townData.Add(new Town() { Name = "Isleworth" });
            }
            return townData;
        }
    }
}