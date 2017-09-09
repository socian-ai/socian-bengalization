using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bengalization
{
    class Program
    {
        // Done
        static string[] ignoreBangla = { "ঃ", "ঁ", "ং" };
        static string[] ignoreEnglish = { "", "", "ng" };



        // Done
        static string[] shoroBornoBangla = { "অ", "আ", "ই", "ঈ", "উ", "ঊ", "ঋ", "এ", "ঐ", "ও", "ঔ" };
        static string[] shoroBornoEnglish = { "o", "a", "i", "i", "u", "u", "ri", "e", "oi", "o", "ou" };




        static string[] karBangla = { "া", "ি", "ী", "ু", "ূ", "ৃ", "ে", "ৈ", "ো", "ৌ" };
        static string[] karEnglish = { "a", "i", "i", "u", "u", "ri", "e", "oi", "o", "ou" };




        static string[] juktoBornoBangla = { "ক্ক", "ক্ট", "ক্ট্র", "ক্ত", "ক্ত্র", "ক্ব", "ক্ম", "ক্য", "ক্র", "ক্ল", "ক্ষ", "ক্ষ্ণ", "ক্ষ্ব", "ক্ষ্ম", "ক্ষ্ম্য", "ক্ষ্য", "ক্স", "খ্য", "খ্র", "গ্‌ণ", "গ্ধ", "গ্ধ্য", "গ্ধ্র", "গ্ন", "গ্ন্য", "গ্ব", "গ্ম", "গ্য", "গ্র", "গ্র্য", "গ্ল", "ঘ্ন", "ঘ্য", "ঘ্র", "ঙ্ক", "ঙ্‌ক্ত", "ঙ্ক্য", "ঙ্ক্ষ", "ঙ্খ", "ঙ্গ", "ঙ্গ্য", "ঙ্ঘ", "ঙ্ঘ্য", "ঙ্ঘ্র", "ঙ্ম", "চ্চ", "চ্ছ", "চ্ছ্ব", "চ্ছ্র", "চ্ঞ", "চ্ব", "চ্য", "জ্জ", "জ্জ্ব", "জ্ঝ", "জ্ঞ", "জ্ব", "জ্য", "জ্র", "ঞ্চ", "ঞ্ছ", "ঞ্জ", "ঞ্ঝ", "ট্ট", "ট্ব", "ট্ম", "ট্য", "ট্র", "ড্ড", "ড্ব", "ড্য", "ড্র", "ড়্গ", "ঢ্য", "ঢ্র", "ণ্ট", "ণ্ঠ", "ণ্ঠ্য", "ণ্ড", "ণ্ড্য", "ণ্ড্র", "ণ্ঢ", "ণ্ণ", "ণ্ব", "ণ্ম", "ণ্য", "ৎক", "ত্ত", "ত্ত্ব", "ত্ত্য", "ত্থ", "ত্ন", "ত্ব", "ত্ম", "ত্ম্য", "ত্য", "ত্র", "ত্র্য", "ৎল", "ৎস", "থ্ব", "থ্য", "থ্র", "দ্গ", "দ্ঘ", "দ্দ", "দ্দ্ব", "দ্ধ", "দ্ব", "দ্ভ", "দ্ভ্র", "দ্ম", "দ্য", "দ্র", "দ্র্য", "ধ্ন", "ধ্ব", "ধ্ম", "ধ্য", "ধ্র", "ন্ট", "ন্ট্র", "ন্ঠ", "ন্ড", "ন্ড্র", "ন্ত", "ন্ত্ব", "ন্ত্য", "ন্ত্র", "ন্ত্র্য", "ন্থ", "ন্থ্র", "ন্দ", "ন্দ্য", "ন্দ্ব", "ন্দ্র", "ন্ধ", "ন্ধ্য", "ন্ধ্র", "ন্ন", "ন্ব", "ন্ম", "ন্য", "প্ট", "প্ত", "প্ন", "প্প", "প্য", "প্র", "প্র্য", "প্ল", "প্স", "ফ্র", "ফ্ল", "ব্জ", "ব্দ", "ব্ধ", "ব্ব", "ব্য", "ব্র", "ব্ল", "ভ্ব", "ভ্য", "ভ্র", "ম্ন", "ম্প", "ম্প্র", "ম্ফ", "ম্ব", "ম্ব্র", "ম্ভ", "ম্ভ্র", "ম্ম", "ম্য", "ম্র", "ম্ল", "য্য", "র্ক", "র্ক্য", "র্গ্য", "র্ঘ্য", "র্চ্য", "র্জ্য", "র্ণ্য", "র্ত্য", "র্থ্য", "র্ব্য", "র্ম্য", "র্শ্য", "র্ষ্য", "র্হ্য", "র্খ", "র্গ", "র্গ্র", "র্ঘ", "র্চ", "র্ছ", "র্জ", "র্ঝ", "র্ট", "র্ড", "র্ণ", "র্ত", "র্ত্র", "র্থ", "র্দ", "র্দ্ব", "র্দ্র", "র্ধ", "র্ধ্ব", "র্ন", "র্প", "র্ফ", "র্ভ", "র্ম", "র্য", "র্ল", "র্শ", "র্শ্ব", "র্ষ", "র্স", "র্হ", "র্ঢ্য", "ল্ক", "ল্ক্য", "ল্গ", "ল্ট", "ল্ড", "ল্প", "ল্‌ফ", "ল্ব", "ল্‌ভ", "ল্ম", "ল্য", "ল্ল", "শ্চ", "শ্ছ", "শ্ন", "শ্ব", "শ্ম", "শ্য", "শ্র", "শ্ল", "ষ্ক", "ষ্ক্র", "ষ্ট", "ষ্ট্য", "ষ্ট্র", "ষ্ঠ", "ষ্ঠ্য", "ষ্ণ", "ষ্প", "ষ্প্র", "ষ্ফ", "ষ্ব", "ষ্ম", "ষ্য", "স্ক", "স্ক্র", "স্খ", "স্ট", "স্ট্র", "স্ত", "স্ত্ব", "স্ত্য", "স্ত্র", "স্থ", "স্থ্য", "স্ন", "স্প", "স্প্র", "স্প্‌ল", "স্ফ", "স্ব", "স্ম", "স্য", "স্র", "স্ল", "হ্ণ", "হ্ন", "হ্ব", "হ্ম", "হ্য", "হ্র", "হ্ল" };
        static string[] juktoBornoEnglish = { "kk", "kT", "kTr", "kt", "ktr", "kk", "km", "kk", "kr", "kl", "kkh", "khn", "kkhb", "kkh", "kkh", "kkh", "ksh", "kh", "khr", "gn", "gdh", "gdh", "gdhr", "gn", "gn", "gb", "gm", "gg", "gr", "gr", "gl", "ghn", "ggh", "ghr", "nk", "nkt", "nk", "nkh", "nkh", "ng", "ng", "ngh", "ngh", "nghr", "ngm", "cch", "cch", "cch", "cchr", "cch", "chb", "cch", "jj", "jj", "jjh", "gg", "j", "jj", "jr", "nch", "nch", "nj", "jjh", "tt", "tt", "tm", "tt", "tr", "dd", "dd", "dd", "dr", "drg", "ddh", "dhr", "nt", "nth", "nth", "nd", "nd", "ndr", "ndh", "nn", "nn", "nm", "nn", "tk", "tt", "tt", "tt", "tth", "tn", "tt", "tt", "tt", "tt", "tr", "tr", "tl", "ts", "tth", "tth", "thr", "dg", "dgh", "dd", "dd", "ddh", "dd", "dv", "dvr", "dm", "dd", "dr", "dr", "dhn", "dh", "dhm", "ddh", "dhr", "nt", "ntr", "nth", "nd", "ndr", "nt", "nt", "nt", "ntr", "ntr", "nth", "nthr", "nd", "nd", "nd", "ndr", "ndh", "ndh", "ndhr", "nn", "nn", "nm", "nn", "pt", "pt", "pn", "pp", "pp", "pr", "pr", "pl", "ps", "fr", "fl", "bj", "bd", "bdh", "bb", "bb", "br", "bl", "vv", "vv", "vr", "mn", "mp", "mpr", "mf", "mb", "mbr", "mv", "mvr", "mm", "mm", "mr", "ml", "jj", "rk", "kr", "rg", "rgh", "rch", "rj", "rn", "rt", "rth", "rb", "rm", "rsh", "rsh", "rh", "rkh", "rg", "rgr", "rgh", "rch", "rch", "rj", "rjh", "rt", "rd", "rn", "rt", "rtr", "rth", "rd", "rd", "rdr", "rdh", "rdh", "rn", "rp", "rf", "rv", "rm", "rz", "rl", "rsh", "rsh", "rsh", "rsh", "rh", "rdh", "lk", "lk", "lg", "lt", "lD", "lp", "lf", "lb", "lv", "lm", "ll", "ll", "shch", "shch", "shn", "ssh", "ssh", "ssh", "shr", "shl", "shk", "shkr", "st", "st", "str", "sth", "sth", "shn", "shp", "shpr", "shf", "sh", "shm", "sh", "sk", "skr", "skh", "st", "str", "st", "st", "st", "str", "sth", "sth", "sn", "sp", "spr", "spl", "sf", "ss", "sm", "sh", "sr", "sl", "hn", "hn", "hb", "hm", "hh", "hr", "hl" };





        static string[] benjonBornoBangla = { "ক", "খ", "গ", "ঘ", "ঙ", "চ", "ছ", "জ", "ঝ", "ঞ", "ট", "ঠ", "ড", "ঢ", "ণ", "ত", "থ", "দ", "ধ", "ন", "প", "ফ", "ব", "ভ", "ম", "য", "র", "ল", "শ", "ষ", "স", "হ", "ড়", "ঢ়", "য়", "ৎ" };
        static string[] benjonBornoEnglish = { "k", "kh", "g", "gh", "n", "ch", "ch", "j", "jh", "n", "t", "th", "d", "dh", "n", "t", "th", "d", "dh", "n", "p", "f", "b", "v", "m", "z", "r", "l", "sh", "sh", "s", "h", "r", "r", "y", "t" };









        static string inputString = "আমার পঁচা পেঁছনে পাঁচ বাংলা নিয়ে প্রথম কাজ করবার সুযোগ তৈরি হয়েছিল অভ্র নামক এক যুগান্তকারী বাংলা সফ্‌টওয়্যারের মধ্য দিয়ে। এর পর একে একে বাংলা উইকিপিডিয়া, ওয়ার্ডপ্রেস বাংলা কোডেক্সসহ বিভিন্ন বাংলা অনলাইন পত্রিকা তৈরির কাজ করতে করতে বাংলার সাথে নিজেকে বেঁধে নিয়েছি আষ্টেপৃষ্ঠে। বিশেষ করে অনলাইন পত্রিকা তৈরি করতে ডিযাইন করার সময়, সেই ডিযাইনকে কোডে রূপান্তর করবার সময় বারবার অনুভব করেছি কিছু নমুনা লেখার। যে লেখাগুলো ফটোশপে বসিয়ে বাংলায় ডিযাইন করা যাবে, আবার সেই লেখাই অনলাইনে ব্যবহার করা যাবে। কিন্তু দুঃখজনক হলেও সত্য যে, ইংরেজিতে লাতিন Lorem Ipsum… সূচক নমুনা লেখা (dummy texts) থাকলেও বাংলা ভাষায় এরকম কোনো লেখা নেই। তাই নিজের তাগিদেই বাংলা ভাষার জন্য প্রথম নমুনা লেখা তৈরি করলাম, এ হলো বাংলা Lorem ipsum – কিন্তু তার অনুবাদ নয়। আমি একে নামকরণ করেছি: অর্থহীন লেখা! আমি কোনো ভাষাবিজ্ঞানী নই। তাই ভাষাগত, শব্দব্যঞ্জনগত শুদ্ধতা, তাল-লয় -এসব বিষয়ে আমার জ্ঞান খুবই প্রাথমিক। তাই এই লেখায় এসব ভাষাবিজ্ঞানগত তাত্ত্বিক উপাদান খুঁজতে যাওয়া অর্থহীন হবে। আমি চেষ্টা করেছি বাংলা ভাষায় দীর্ঘ শব্দ রাখতে, তবে তা দীর্ঘতম – এমন দাবি আমি করছি না। আমি চেষ্টা করেছি, অংক (সংখ্যা) রাখতে, যাতে ফন্টের অবয়বটা টের পাওয়া যায়। আমি চেষ্টা করেছি যুক্তাক্ষর রাখতে, যতিচিহ্ন রাখতে,… অর্ধমাত্রার অক্ষর, পূর্ণমাত্রার অক্ষর, মাত্রাহীন অক্ষর, কার-ফলাযুক্ত শব্দ, বাক্যের এখানে-ওখানে রাখতে। বাংলা সব অক্ষর রাখার একটা চেষ্টা ছিল। কিন্তু তা ব্যর্থ – আমি শেষে এই চেষ্টা করাটাকেই অপ্রয়োজনীয় মনে করলাম। এ-তো আর বাংলা ভাষার আগার হচ্ছে না, এ হলো পরম্পরাহীন, কিংবা তাৎপর্যপূর্ণ একটি লেখা, যা বাংলা ভাষার প্রতিনিধিত্ব করবে টাইপসেটিং, প্রিন্টিং, ইন্ডাস্ট্রিতে কিংবা ওয়েব ডিযাইনে।";


        static void Main(string[] args)
        {
            // ChondroBindu & Bishorgo Handling
            for (int i = 0; i < ignoreBangla.Length; i++)
            {
                if (inputString.Contains(ignoreBangla[i]))
                {
                    inputString = inputString.Replace(ignoreBangla[i], ignoreEnglish[i]);
                }
            }

            // Shoroborno Handling
            for (int i = 0; i < shoroBornoBangla.Length; i++)
            {
                if (inputString.Contains(shoroBornoBangla[i]))
                {
                    inputString = inputString.Replace(shoroBornoBangla[i], shoroBornoEnglish[i]);
                }
            }

            // Juktoborno with Kar Handling
            for (int i = 0; i < karBangla.Length; i++)
            {
                for (int j = 0; j < juktoBornoBangla.Length; j++)
                {
                    if (inputString.Contains(juktoBornoBangla[j] + karBangla[i]))
                    {
                        inputString = inputString.Replace(juktoBornoBangla[j] + karBangla[i], juktoBornoEnglish[j] + karEnglish[i]);
                    }
                }
            }

            // Juktoborno Ending with Space and Without Kar Handling
            for (int i = 0; i < juktoBornoBangla.Length; i++)
            {
                if (inputString.Contains(juktoBornoBangla[i]))
                {
                    inputString = inputString.Replace(juktoBornoBangla[i], juktoBornoEnglish[i] + "o");
                }
            }

            // BenjonBorno Ending with Space Handling
            for (int i = 0; i < benjonBornoBangla.Length; i++)
            {
                if (inputString.Contains(benjonBornoBangla[i] + " "))
                {
                    inputString = inputString.Replace(benjonBornoBangla[i] + " ", benjonBornoEnglish[i] + " ");
                }
            }

            // BenjonBorno with Kar Handling
            for (int i = 0; i < karBangla.Length; i++)
            {
                for (int j = 0; j < benjonBornoBangla.Length; j++)
                {
                    if (inputString.Contains(benjonBornoBangla[j] + karBangla[i]))
                    {
                        inputString = inputString.Replace(benjonBornoBangla[j] + karBangla[i], benjonBornoEnglish[j] + karEnglish[i]);
                    }
                }
            }

            // BenjonBorno Not Ending with Space and Without Kar Handling
            for (int i = 0; i < benjonBornoBangla.Length; i++)
            {
                if (inputString.Contains(benjonBornoBangla[i]))
                {
                    if (benjonBornoBangla[i].Equals("র"))
                    {
                        inputString = inputString.Replace("র", "r");
                    }
                    else
                    {
                        inputString = inputString.Replace(benjonBornoBangla[i], benjonBornoEnglish[i] + "o");
                    }
                }
            }

            Console.WriteLine(inputString);
        }
    }
}
