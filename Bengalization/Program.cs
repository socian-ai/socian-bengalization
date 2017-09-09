using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengalization
{
    class Program
    {
        static string[] endingCharacters = { " ", ",", "!", "?", "." };




        // Done
        static string[] ignoreBangla = { "ং", "।" };
        static string[] ignoreEnglish = { "ng", "." };



        // Done
        static string[] shoroBornoBangla = { "অ", "আ", "ই", "ঈ", "উ", "ঊ", "ঋ", "এ", "ঐ", "ও", "ঔ" };
        static string[] shoroBornoEnglish = { "o", "a", "i", "i", "u", "u", "ri", "e", "oi", "o", "ou" };




        static string[] karBangla = { "া", "ি", "ী", "ু", "ূ", "ৃ", "ে", "ৈ", "ো", "ৌ" };
        static string[] karEnglish = { "a", "i", "i", "u", "u", "ri", "e", "oi", "o", "ou" };




        static string[] juktoBornoBanglaBeforeSpaceWithAKar = { " ক্যা", " ক্ষ্যা", " খ্যা", " গ্যা", " গ্র্যা", " ঘ্যা", " চ্যা", " জ্যা", " ট্যা", " ড্যা", " ঢ্যা", " ণ্যা", " ত্ত্যা", " ত্ম্যা", " ত্যা", " ত্র্যা", " থ্যা", " দ্যা", " দ্র্যা", " ধ্যা", " ন্যা", " প্যা", " প্র্যা", " ব্যা", " ভ্যা", " ম্যা", " য্যা", " ল্যা", " শ্যা", " ষ্ট্যা", " ষ্ঠ্যা", " ষ্যা", " স্ত্যা", " স্থ্যা", " স্যা", " হ্যা", " ক্ট্র্যা", " ক্ব্যা", " ক্র্যা", " ক্ল্যা", " ক্ষ্যা", " খ্র্যা", " গ্ন্যা", " গ্র্যা", " গ্ল্যা", " ঘ্ন্যা", " ঘ্র্যা", " চ্ব্যা", " জ্ঞ্যা", " জ্ব্যা", " জ্র্যা", " ট্ব্যা", " ট্র্যা", " ড্ব্যা", " ড্র্যা", " ঢ্র্যা", " ণ্ব্যা", " ত্ত্ব্যা", " ত্ন্যা", " ত্ব্যা", " ত্র্যা", " থ্ব্যা", " থ্র্যা", " দ্ব্যা", " দ্র্যা", " ধ্র্যা", " ন্ব্যা", " প্র্যা", " ফ্র্যা", " ব্র্যা", " ব্ল্যা", " ভ্ব্যা", " ভ্র্যা", " ম্র্যা", " ম্ল্যা", " শ্র্যা", " শ্ল্যা", " ষ্ক্যা", " ষ্ক্র্যা", " ষ্ট্যা", " ষ্ট্র্যা", " ষ্ঠ্যা", " ষ্প্যা", " ষ্প্র্যা", " ষ্ফ্যা", " ষ্ব্যা", " ষ্ম্যা", " স্ক্যা", " স্ক্র্যা", " স্খ্যা", " স্ট্যা", " স্ট্র্যা", " স্ত্যা", " স্ত্ব্যা", " স্ত্র্যা", " স্থ্যা", " স্ন্যা", " স্প্যা", " স্প্র্যা", " স্ফ্যা", " স্ব্যা", " স্ম্যা", " স্র্যা", " স্ল্যা", " হ্ণ্যা" };
        static string[] juktoBornoEnglishBeforeSpaceWithAKar = { " ke", " khe", " khe", " ge", " gre", " ghe", " che", " je", " te", " de", " dhe", " ne", " te", " te", " te", " tre", " the", " de", " dre", " dhe", " ne", " pe", " pre", " be", " ve", " me", " ze", " le", " she", " ste", " sthe", " she", " ste", " sthe", " she", " he", " ktre", " kke", " kre", " kle", " khe", " khre", " gne", " gre", " gle", " ghne", " ghre", " che", " ge", " je", " jre", " te", " tre", " de", " dre", " dhre", " ne", " te", " tne", " te", " tre", " the", " thre", " de", " dre", " dhre", " ne", " pre", " fre", " bre", " ble", " ve", " vre", " mre", " mle", " shre", " shle", " shke", " shkre", " ste", " stre", " sthe", " shpe", " shpre", " shfe", " she", " shme", " ske", " skre", " skhe", " ste", " stre", " ste", " ste", " stre", " sthe", " sne", " spe", " spre", " sfe", " se", " sme", " sre", " sle", " hne" };



        static string[] juktoBornoBanglaBeforeSpace = { " ক্য", " ক্ষ্য", " খ্য", " গ্য", " গ্র্য", " ঘ্য", " চ্য", " জ্য", " ট্য", " ড্য", " ঢ্য", " ণ্য", " ত্ত্য", " ত্ম্য", " ত্য", " ত্র্য", " থ্য", " দ্য", " দ্র্য", " ধ্য", " ন্য", " প্য", " প্র্য", " ব্য", " ভ্য", " ম্য", " য্য", " ল্য", " শ্য", " ষ্ট্য", " ষ্ঠ্য", " ষ্য", " স্ত্য", " স্থ্য", " স্য", " হ্য", " ক্ট্র্য", " ক্ব্য", " ক্র্য", " ক্ল্য", " ক্ষ্য", " খ্র্য", " গ্ন্য", " গ্র্য", " গ্ল্য", " ঘ্ন্য", " ঘ্র্য", " চ্ব্য", " জ্ঞ্য", " জ্ব্য", " জ্র্য", " ট্ব্য", " ট্র্য", " ড্ব্য", " ড্র্য", " ঢ্র্য", " ণ্ব্য", " ত্ত্ব্য", " ত্ন্য", " ত্ব্য", " ত্র্য", " থ্ব্য", " থ্র্য", " দ্ব্য", " দ্র্য", " ধ্র্য", " ন্ব্য", " প্র্য", " ফ্র্য", " ব্র্য", " ব্ল্য", " ভ্ব্য", " ভ্র্য", " ম্র্য", " ম্ল্য", " শ্র্য", " শ্ল্য", " ষ্ক্য", " ষ্ক্র্য", " ষ্ট্য", " ষ্ট্র্য", " ষ্ঠ্য", " ষ্প্য", " ষ্প্র্য", " ষ্ফ্য", " ষ্ব্য", " ষ্ম্য", " স্ক্য", " স্ক্র্য", " স্খ্য", " স্ট্য", " স্ট্র্য", " স্ত্য", " স্ত্ব্য", " স্ত্র্য", " স্থ্য", " স্ন্য", " স্প্য", " স্প্র্য", " স্ফ্য", " স্ব্য", " স্ম্য", " স্র্য", " স্ল্য", " হ্ণ্য" };
        static string[] juktoBornoEnglishBeforeSpace = { " ke", " khe", " khe", " ge", " gre", " ghe", " che", " je", " te", " de", " dhe", " ne", " te", " te", " te", " tre", " the", " de", " dre", " dhe", " ne", " pe", " pre", " be", " ve", " me", " ze", " le", " she", " ste", " sthe", " she", " ste", " sthe", " she", " he", " ktre", " kke", " kre", " kle", " khe", " khre", " gne", " gre", " gle", " ghne", " ghre", " che", " ge", " je", " jre", " te", " tre", " de", " dre", " dhre", " ne", " te", " tne", " te", " tre", " the", " thre", " de", " dre", " dhre", " ne", " pre", " fre", " bre", " ble", " ve", " vre", " mre", " mle", " shre", " shle", " shke", " shkre", " ste", " stre", " sthe", " shpe", " shpre", " shfe", " she", " shme", " ske", " skre", " skhe", " ste", " stre", " ste", " ste", " stre", " sthe", " sne", " spe", " spre", " sfe", " se", " sme", " sre", " sle", " hne" };








        static string[] juktoBornoBangla = { "ক্ক", "ক্ট", "ক্ট্র", "ক্ত", "ক্ত্র", "ক্ব", "ক্ম", "ক্র", "ক্ল", "ক্ষ", "ক্ষ্ণ", "ক্ষ্ব", "ক্ষ্ম", "ক্ষ্ম্য", "ক্স", "খ্র", "গ্‌ণ", "গ্ধ", "গ্ধ্য", "গ্ধ্র", "গ্ন", "গ্ন্য", "গ্ব", "গ্ম", "গ্র", "গ্ল", "ঘ্ন", "ঘ্র", "ঙ্ক", "ঙ্‌ক্ত", "ঙ্ক্য", "ঙ্ক্ষ", "ঙ্খ", "ঙ্গ", "ঙ্গ্য", "ঙ্ঘ", "ঙ্ঘ্য", "ঙ্ঘ্র", "ঙ্ম", "চ্চ", "চ্ছ", "চ্ছ্ব", "চ্ছ্র", "চ্ঞ", "চ্ব", "জ্জ", "জ্জ্ব", "জ্ঝ", "জ্ঞ", "জ্ব", "জ্র", "ঞ্চ", "ঞ্ছ", "ঞ্জ", "ঞ্ঝ", "ট্ট", "ট্ব", "ট্ম", "ট্র", "ড্ড", "ড্ব", "ড্র", "ড়্গ", "ঢ্র", "ণ্ট", "ণ্ঠ", "ণ্ঠ্য", "ণ্ড", "ণ্ড্য", "ণ্ড্র", "ণ্ঢ", "ণ্ণ", "ণ্ব", "ণ্ম", "ৎক", "ত্ত", "ত্ত্ব", "ত্থ", "ত্ন", "ত্ব", "ত্ম", "ত্র", "ৎল", "ৎস", "থ্ব", "থ্র", "দ্গ", "দ্ঘ", "দ্দ", "দ্দ্ব", "দ্ধ", "দ্ব", "দ্ভ", "দ্ভ্র", "দ্ম", "দ্র", "ধ্ন", "ধ্ব", "ধ্ম", "ধ্র", "ন্ট", "ন্ট্র", "ন্ঠ", "ন্ড", "ন্ড্র", "ন্ত", "ন্ত্ব", "ন্ত্য", "ন্ত্র", "ন্ত্র্য", "ন্থ", "ন্থ্র", "ন্দ", "ন্দ্য", "ন্দ্ব", "ন্দ্র", "ন্ধ", "ন্ধ্য", "ন্ধ্র", "ন্ন", "ন্ব", "ন্ম", "প্ট", "প্ত", "প্ন", "প্প", "প্র", "প্ল", "প্স", "ফ্র", "ফ্ল", "ব্জ", "ব্দ", "ব্ধ", "ব্ব", "ব্র", "ব্ল", "ভ্ব", "ভ্র", "ম্ন", "ম্প", "ম্প্র", "ম্ফ", "ম্ব", "ম্ব্র", "ম্ভ", "ম্ভ্র", "ম্ম", "ম্র", "ম্ল", "র্ক", "র্ক্য", "র্গ্য", "র্ঘ্য", "র্চ্য", "র্জ্য", "র্ণ্য", "র্ত্য", "র্থ্য", "র্ব্য", "র্ম্য", "র্শ্য", "র্ষ্য", "র্হ্য", "র্খ", "র্গ", "র্গ্র", "র্ঘ", "র্চ", "র্ছ", "র্জ", "র্ঝ", "র্ট", "র্ড", "র্ণ", "র্ত", "র্ত্র", "র্থ", "র্দ", "র্দ্ব", "র্দ্র", "র্ধ", "র্ধ্ব", "র্ন", "র্প", "র্ফ", "র্ভ", "র্ম", "র্য", "র্ল", "র্শ", "র্শ্ব", "র্ষ", "র্স", "র্হ", "র্ঢ্য", "ল্ক", "ল্ক্য", "ল্গ", "ল্ট", "ল্ড", "ল্প", "ল্‌ফ", "ল্ব", "ল্‌ভ", "ল্ম", "ল্ল", "শ্চ", "শ্ছ", "শ্ন", "শ্ব", "শ্ম", "শ্র", "শ্ল", "ষ্ক", "ষ্ক্র", "ষ্ট", "ষ্ট্র", "ষ্ঠ", "ষ্ণ", "ষ্প", "ষ্প্র", "ষ্ফ", "ষ্ব", "ষ্ম", "স্ক", "স্ক্র", "স্খ", "স্ট", "স্ট্র", "স্ত", "স্ত্ব", "স্ত্র", "স্থ", "স্ন", "স্প", "স্প্র", "স্প্‌ল", "স্ফ", "স্ব", "স্ম", "স্র", "স্ল", "হ্ণ", "হ্ন", "হ্ব", "হ্ম", "হ্র", "হ্ল", "ক্য", "ক্ষ্য", "খ্য", "গ্য", "গ্র্য", "ঘ্য", "চ্য", "জ্য", "ট্য", "ড্য", "ঢ্য", "ণ্য", "ত্ত্য", "ত্ম্য", "ত্য", "ত্র্য", "থ্য", "দ্য", "দ্র্য", "ধ্য", "ন্য", "প্য", "প্র্য", "ব্য", "ভ্য", "ম্য", "য্য", "ল্য", "শ্য", "ষ্ট্য", "ষ্ঠ্য", "ষ্য", "স্ত্য", "স্থ্য", "স্য", "হ্য", "ক্ট্র্য", "ক্ব্য", "ক্র্য", "ক্ল্য", "ক্ষ্য", "খ্র্য", "গ্ন্য", "গ্র্য", "গ্ল্য", "ঘ্ন্য", "ঘ্র্য", "চ্ব্য", "জ্ঞ্য", "জ্ব্য", "জ্র্য", "ট্ব্য", "ট্র্য", "ড্ব্য", "ড্র্য", "ঢ্র্য", "ণ্ব্য", "ত্ত্ব্য", "ত্ন্য", "ত্ব্য", "ত্র্য", "থ্ব্য", "থ্র্য", "দ্ব্য", "দ্র্য", "ধ্র্য", "ন্ব্য", "প্র্য", "ফ্র্য", "ব্র্য", "ব্ল্য", "ভ্ব্য", "ভ্র্য", "ম্র্য", "ম্ল্য", "শ্র্য", "শ্ল্য", "ষ্ক্য", "ষ্ক্র্য", "ষ্ট্য", "ষ্ট্র্য", "ষ্ঠ্য", "ষ্প্য", "ষ্প্র্য", "ষ্ফ্য", "ষ্ব্য", "ষ্ম্য", "স্ক্য", "স্ক্র্য", "স্খ্য", "স্ট্য", "স্ট্র্য", "স্ত্য", "স্ত্ব্য", "স্ত্র্য", "স্থ্য", "স্ন্য", "স্প্য", "স্প্র্য", "স্ফ্য", "স্ব্য", "স্ম্য", "স্র্য", "স্ল্য", "হ্ণ্য" };
        static string[] juktoBornoEnglish = { "kk", "kT", "kTr", "kt", "ktr", "kk", "km", "kr", "kl", "kkh", "khn", "kkhb", "kkh", "kkh", "ksh", "khr", "gn", "gdh", "gdh", "gdhr", "gn", "gn", "gb", "gm", "gr", "gl", "ghn", "ghr", "nk", "nkt", "nk", "nkh", "nkh", "ng", "ng", "ngh", "ngh", "nghr", "ngm", "cch", "cch", "cch", "cchr", "cch", "ch", "jj", "jj", "jjh", "gg", "j", "jr", "nch", "nch", "nj", "jjh", "tt", "tt", "tm", "tr", "dd", "dd", "dr", "drg", "dhr", "nt", "nth", "nth", "nd", "nd", "ndr", "ndh", "nn", "nn", "nm", "tk", "tt", "tt", "tth", "tn", "tt", "tt", "tr", "tl", "ts", "tth", "thr", "dg", "dgh", "dd", "dd", "ddh", "dd", "dv", "dvr", "dm", "dr", "dhn", "dh", "dhm", "dhr", "nt", "ntr", "nth", "nd", "ndr", "nt", "nt", "nt", "ntr", "ntr", "nth", "nthr", "nd", "nd", "nd", "ndr", "ndh", "ndh", "ndhr", "nn", "nn", "nm", "pt", "pt", "pn", "pp", "pr", "pl", "ps", "fr", "fl", "bj", "bd", "bdh", "bb", "br", "bl", "vv", "vr", "mn", "mp", "mpr", "mf", "mb", "mbr", "mv", "mvr", "mm", "mr", "ml", "rk", "kr", "rg", "rgh", "rch", "rj", "rn", "rt", "rth", "rb", "rm", "rsh", "rsh", "rh", "rkh", "rg", "rgr", "rgh", "rch", "rch", "rj", "rjh", "rt", "rd", "rn", "rt", "rtr", "rth", "rd", "rd", "rdr", "rdh", "rdh", "rn", "rp", "rf", "rv", "rm", "rz", "rl", "rsh", "rsh", "rsh", "rsh", "rh", "rdh", "lk", "lk", "lg", "lt", "lD", "lp", "lf", "lb", "lv", "lm", "ll", "shch", "shch", "shn", "ssh", "ssh", "shr", "shl", "shk", "shkr", "st", "str", "sth", "shn", "shp", "shpr", "shf", "sh", "shm", "sk", "skr", "skh", "st", "str", "st", "st", "str", "sth", "sn", "sp", "spr", "spl", "sf", "ss", "sm", "sr", "sl", "hn", "hn", "hb", "hm", "hr", "hl", "kk", "kkh", "kh", "gg", "gr", "ggh", "cch", "jj", "tt", "dd", "ddh", "nn", "tt", "tt", "tt", "tr", "tth", "dd", "dr", "ddh", "nn", "pp", "pr", "bb", "vv", "mm", "zz", "ll", "ssh", "st", "sth", "sh", "st", "sth", "sh", "hh", "kTr", "kk", "kr", "kl", "kkh", "khr", "gn", "gr", "gl", "ghn", "ghr", "ch", "gg", "j", "jr", "tt", "tr", "dd", "dr", "dhr", "nn", "tt", "tn", "tt", "tr", "tth", "thr", "dd", "dr", "dhr", "nn", "pr", "fr", "br", "bl", "vv", "vr", "mr", "ml", "shr", "shl", "shk", "shkr", "st", "str", "sth", "shp", "shpr", "shf", "sh", "shm", "sk", "skr", "skh", "st", "str", "st", "st", "str", "sth", "sn", "sp", "spr", "sf", "ss", "sm", "sr", "sl", "hn" };



        static string[] benjonBornoBangla = { "ক", "খ", "গ", "ঘ", "ঙ", "চ", "ছ", "জ", "ঝ", "ঞ", "ট", "ঠ", "ড", "ঢ", "ণ", "ত", "থ", "দ", "ধ", "ন", "প", "ফ", "ব", "ভ", "ম", "য", "র", "ল", "শ", "ষ", "স", "হ", "ড়", "ঢ়", "য়", "ৎ" };
        static string[] benjonBornoEnglish = { "k", "kh", "g", "gh", "n", "ch", "ch", "j", "jh", "n", "t", "th", "d", "dh", "n", "t", "th", "d", "dh", "n", "p", "f", "b", "v", "m", "z", "r", "l", "sh", "sh", "s", "h", "r", "r", "y", "t" };









        static string inputString;

        static void Main(string[] args)
        {

            var lines = File.ReadAllText(@"H:\SOCIAN\LanguageTrainTool\BengalizationRev\Solutions\Banglish\banglish.txt");

            
            inputString = lines.ToString();
            

            // JuktoBorno Starting with Space Before Handling with AKar
            for (int i = 0; i < juktoBornoEnglishBeforeSpaceWithAKar.Length; i++)
            {
                if (inputString.Contains(juktoBornoEnglishBeforeSpaceWithAKar[i]))
                {
                    inputString = inputString.Replace(juktoBornoEnglishBeforeSpaceWithAKar[i], juktoBornoBanglaBeforeSpaceWithAKar[i]);
                }
            }


            // JuktoBorno Starting with Space Before Handling
            for (int i = 0; i < juktoBornoEnglishBeforeSpace.Length; i++)
            {
                if (inputString.Contains(juktoBornoEnglishBeforeSpace[i]))
                {
                    inputString = inputString.Replace(juktoBornoEnglishBeforeSpace[i], juktoBornoBanglaBeforeSpace[i]);
                }
            }


            // ChondroBindu, Bishorgo, Dari Handling
            for (int i = 0; i < ignoreEnglish.Length; i++)
            {
                if (inputString.Contains(ignoreEnglish[i]))
                {
                    inputString = inputString.Replace(ignoreEnglish[i], ignoreBangla[i]);
                }
            }

            // Shoroborno Handling
            for (int i = 0; i < shoroBornoEnglish.Length; i++)
            {
                if (inputString.Contains(shoroBornoEnglish[i]))
                {
                    inputString = inputString.Replace(shoroBornoEnglish[i], shoroBornoBangla[i]);
                }
            }



            // Juktoborno with Kar Handling
            for (int i = 0; i < karEnglish.Length; i++)
            {
                for (int j = 0; j < juktoBornoEnglish.Length; j++)
                {
                    if (inputString.Contains(juktoBornoEnglish[j] + karEnglish[i]))
                    {
                        inputString = inputString.Replace(juktoBornoEnglish[j] + karEnglish[i], juktoBornoBangla[j] + karBangla[i]);
                    }
                }
            }

            // Juktoborno Ending with/without Space, Comma, Question, Exclamation and Without Kar Handling
            for (int i = 0; i < juktoBornoEnglish.Length; i++)
            {
                if (inputString.Contains(juktoBornoEnglish[i]))
                {
                    inputString = inputString.Replace(juktoBornoEnglish[i], juktoBornoBangla[i] + "o");
                }
            }

            // BenjonBorno Ending with Ending Characters Handling
            for (int j = 0; j < endingCharacters.Length; j++) 
            {
                for (int i = 0; i < benjonBornoEnglish.Length; i++)
                {
                    if (inputString.Contains(benjonBornoEnglish[i] + endingCharacters[j]))
                    {
                        if ((benjonBornoEnglish[i] + endingCharacters[j]).Equals("হ" + endingCharacters[j]))
                        {
                            inputString = inputString.Replace(benjonBornoEnglish[i] + endingCharacters[j], benjonBornoBangla[i] + "o" + endingCharacters[j]);
                        }
                        else
                        {
                            inputString = inputString.Replace(benjonBornoEnglish[i] + endingCharacters[j], benjonBornoBangla[i] + endingCharacters[j]);
                        }
                    }
                }
            }


            // BenjonBorno with Kar Handling
            for (int i = 0; i < karEnglish.Length; i++)
            {
                for (int j = 0; j < benjonBornoEnglish.Length; j++)
                {
                    if (inputString.Contains(benjonBornoEnglish[j] + karEnglish[i]))
                    {
                        inputString = inputString.Replace(benjonBornoEnglish[j] + karEnglish[i], benjonBornoBangla[j] + karBangla[i]);
                    }
                }
            }




            // Exception Cases where the BenjonBorno doesn't follow the rules
            if (inputString.Contains("ro"))
            {
                inputString = inputString.Replace("ro", " র");
            }
            else if (inputString.Contains("no"))
            {
                inputString = inputString.Replace("no", " ন");
            }

            // BenjonBorno Not Ending with Space and Without Kar Handling
            for (int i = 0; i < benjonBornoEnglish.Length; i++)
            {
                if (inputString.Contains(benjonBornoEnglish[i]))
                {
                    if (benjonBornoEnglish[i].Equals("r"))
                    {
                        inputString = inputString.Replace("r", "র");
                    }
                    else if (benjonBornoEnglish[i].Equals("n"))
                    {
                        inputString = inputString.Replace("n", "ন");
                    }
                    else
                    {
//                        inputString = inputString.Replace(benjonBornoEnglish[i], benjonBornoBangla[i] + "ো");
                    }
                }
            }

            //if (inputString.Contains("chil "))
            //{
            //    inputString = inputString.Replace("chil ", "chilo ");
            //}

            File.WriteAllText(@"H:\SOCIAN\LanguageTrainTool\BengalizationRev\Solutions\Bengali\bengali.txt", inputString);
        }
    }
}
