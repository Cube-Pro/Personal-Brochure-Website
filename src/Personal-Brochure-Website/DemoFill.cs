using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Brochure_Website
{
    public class DemoFill
    {
        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string FillWithLatinText(int NumberOfWords)
        {
            int i = 0;
            var placeholder = 0;
            var wordsInSentance = 0;
            var numberOfSentances = 0;

            Random randNum = new Random();
            //Initialize length of first sentance
            var maxWords = randNum.Next(3, 8);
            //List of Latin Words
            string[] words = { "alveolus", "fulvus", "pala", "fortis", "galea", "ānser", "gracilis", "cortex", "castrum", "fēmina", "amplus", "lapis", "pediculus", "nāvis", "cilium", "vernus", "ovum", "cinis", "cornus", "flōs", "mel", "sonus", "dos", "posterus", "eruca", "rotula", "monticellus", "foedus", "frustum", "titulus", "nepōs", "uncia", "frīgusculum", "cariēs", "mors", "quadrāgintā", "quiēs", "nebula", "quattuor", "crispus", "flagrum", "vinum", "quīndecim", "fimus", "quartus", "numerus", "missa", "brevis", "acinus", "gradus", "turba", "viceni", "pulmo", "cuneus", "fuscus", "fungus", "clāvicula", "planta", "mortuus", "regulus", "rostellum", "avēna", "rāna", "liber", "ferox", "reticulum", "stella", "furcula", "fretum", "capsula", "asinus", "purus", "pinnaculum", "pēs", "bene", "culex", "angellus", "glacies", "digitus", "mollis", "collis", "oculus", "quadrini", "lenis", "cancelli", "acervulus", "solidus", "decem", "fauces", "ānulus", "parvus", "decus", "equus", "adeps", "uncus", "sex", "flavus", "clarus", "passer", "fimbriae", "frīgus", "sexagesimus", "alacer", "aestas", "silva", "corpusculum", "frōns", "fūnis", "littera", "carīna", "quattuordecim", "unus", "curvus", "ulcus", "codex", "liber", "plēbs", "capsa", "os", "crēna", "aes", "ceterus", "quadrageni", "pinus", "dens", "imbecillus", "auricula", "cicātrīx", "ferus", "vitium", "cauda", "rivus", "iūs", "sanus", "citer", "solum", "pilus", "quadrāgēsimus", "signum", "mūsculus", "nāvicella", "pestis", "urbs", "inanis", "plūma", "prex", "mūlus", "herba", "bellum", "capillus", "orbiculus", "gallīnula", "ūber", "granum", "suavis", "hibernus", "undecim", "pinna", "flamma", "ulmus", "planca", "hircus", "odium", "corpus", "tardus", "opusculum", "artūs", "calx", "tabula", "stuppa", "furcilla", "parcus", "potis", "lac", "plumbum", "venus", "sūrus", "stips", "vespa", "folium", "pōcillum", "mare", "sagina", "arbor", "modus", "cūlus", "rota", "cūpella", "socius", "nudus", "ūvula", "muria", "septimus", "ignis", "privus", "asper", "glaber", "avis", "niger", "crassus", "surdus", "fōrma", "plenus", "singulus", "pulvinus", "axis", "neuter", "ventus", "genū", "stilus", "mitis", "velox", "exterus", "māter", "bāiulus", "unguis", "radius", "via", "gustus", "pus", "furca", "mucus", "antenna", "deter", "pax", "culina", "iugum", "color", "portus", "frutex", "rānula", "solium", "cumulus", "focus", "nīdus", "aucella", "manus", "tubulus", "lūna", "ulter", "castus", "ocellus", "par", "cervus", "foliolum", "opacus", "magnus", "labia", "luxus", "vindex", "spūma", "tussis", "iūdex", "vanus", "corculum", "quadrellus", "leo", "quīnī", "lux", "stilla", "costa", "vallum", "cauliculus", "fēlēs", "frustillum", "fanum", "arma", "cuspis", "aevum", "caput", "noster", "crīnis", "mora", "levis", "frustulum", "nāsus", "pupa", "iocus", "similis", "ōscen", "fidēs", "palatum", "mōs", "ripa", "octogeni", "ossiculum", "fors", "ficus", "cornicula", "vellus", "dignus", "hallux", "stuprum", "hebes", "baca", "bōs", "glāns", "aquula", "saepēs", "gutta", "pausa", "nucula", "bestia", "firmus", "bini", "hāmulus", "hedera", "arduus", "squāma", "crux", "formula", "glomerulus", "pollen", "folliculus", "cribellum", "currus", "vassallus", "sextus", "fēlix", "mundus", "merus", "gravis", "sacer", "hiems", "mūrex", "lēx", "hāmus", "pălus", "faber", "formella", "vesper", "macula", "palla", "prior", "vīlis", "valgus", "bulbulus", "terni", "lepus", "misellus", "septeni", "sinister", "mūtus", "humus", "avicula", "rāpulum", "dōnum", "accipiter", "spiculum", "particula", "spina", "ruga", "animus", "vacca", "semis", "aemulus", "mēta", "grossus", "rāmulus", "prandium", "bacillum", "acicula", "venēnum", "alter", "pulcher", "collum", "clavis", "ancūla", "nāris", "femur", "durus", "Mars", "virga", "novellus", "fūnus", "culter", "mulier", "germen", "corvus", "umbra", "fatuus", "ritus", "osculum", "bassus", "drappus", "cavus", "vēxillum", "mucrō", "testis", "nūbēs", "dominus", "fūsus", "abdomen", "densus", "anima", "crēnula", "cūpula", "annus", "rāpa", "anguiculus", "geminus", "lacus", "catēnula", "lupus", "īnsula", "opus", "tubus", "duplus", "celeber", "genus", "octōni", "aequus", "supīnus", "honor", "vulpēs", "cucurbita", "angulus", "rostrulum", "botulus", "tres", "vīlla", "alternus", "vestigium", "corcillum", "duodecim", "bracchium", "plūmula", "vīgēsimus", "rēx", "fūmus", "sors", "vērus", "harena", "rosula", "flocculus", "carcer", "gelu", "vetus", "semen", "panis", "vermis", "vicis", "festus", "deus", "filum", "aquila", "bellus", "cribrum", "malleus", "nūmen", "gallīna", "mīlle", "rānunculus", "hasta", "domus", "mūtulus", "ostiolum", "crusta", "rādīx", "panicula", "pondus", "gladius", "omnis", "gurges", "corium", "sorticula", "strix", "sucus", "carbo", "lassus", "cotoneum", "rumen", "pectus", "nodulus", "inferus", "glēba", "fīlia", "sterilis", "cultellus", "furtum", "cirrus", "centum", "sexageni", "vox", "lira", "valva", "vērātrum", "moles", "vōcula", "villus", "barba", "sibilus", "rēn", "verbum", "gula", "interus", "iuvenis", "alius", "pullulus", "culcita", "taberna", "capitellum", "prunus", "menda", "octōdecim", "cucullus", "vola", "sinus", "pulvis", "mirus", "ānus", "fūniculus", "res", "ungula", "probus", "omen", "quintus", "craticula", "dorsum", "discipulus", "publicus", "magister", "fovea", "rūs", "cīvis", "monticulus", "fenestra", "vermiculus", "gratus", "caper", "vāscellum", "cārus", "pollex", "cibus", "nōnus", "frāter", "canis", "spēs", "gemellus", "ostium", "maturus", "apis", "pars", "colliculus", "camera", "fascis", "avunculus", "pullus", "frequēns", "barbula", "mūscus", "cōlum", "lentus", "panus", "radicula", "limbus", "pretium", "saxum", "pālus", "corbis", "morbus", "venum", "fiscus", "lens", "novem", "decimus", "frūx", "octōgēsimus", "ager", "onus", "nihil", "fraus", "glandula", "ovulum", "crimen", "libra", "granulum", "limes", "āla", "uterus", "pius", "duodecimus", "medius", "fornix", "prope", "deni", "pluvia", "ops", "gemma", "acētum", "trīnī", "armilla", "soccus", "caro", "nonagesimus", "ruber", "susurrus", "pilula", "orbis", "hostis", "spica", "grandis", "stria", "tōtus", "lingua", "asellus", "tricae", "malus", "cūnae", "multus", "socculus", "solus", "pila", "acervus", "aqua", "millēsimus", "tertius", "rotella", "causa", "grex", "baculum", "labor", "saeculum", "soror", "nīdor", "fons", "fur", "memor", "quadrum", "siccus", "certus", "beatus", "squāmula", "viscus", "culpa", "anguilla", "nugae", "gemmula", "gens", "artus", "venter", "musca", "faenum", "dulcis", "fibra", "audāx", "viverra", "vestis", "septem", "corniculum", "diēs", "gluten", "stipula", "paluster", "centeni", "stipes", "buccula", "aedes", "jejunus", "creta", "fībula", "sulcus", "divus", "arvus", "glabellus", "lacrima", "membrum", "sūra", "armus", "cippus", "vāgīna", "labrum", "nodus", "fūstis", "multa", "ursus", "passus", "bonus", "gibbus", "penna", "tabella", "sopor", "papilio", "mantum", "cras", "paries", "uxor", "norma", "terminus", "planus", "acerbus", "spatium", "fīnis", "otium", "custos", "ācer", "pater", "linea", "lumen", "catēna", "nomen", "floccus", "festūca", "sūrculus", "caballus", "fibrilla", "vulnus", "acus", "crapula", "acer", "vicus", "somnium", "globus", "crātis", "dirus", "oleum", "capsella", "curtus", "bursa", "pileus", "arcus", "codicillus", "pavo", "fundus", "tribus", "mustus", "lignum", "undeni", "clemens", "carduus", "papaver", "vitrum", "ensis", "nervus", "vagus", "nāpus", "argentum", "cor", "mutilus", "taedium", "albus", "feudum", "loculus", "corona", "allium", "saeta", "nidulus", "stagnum", "ūva", "perca", "faba", "sol", "lucrum", "somnus", "sūs", "proprius", "mens", "pons", "rūdis", "cāseus", "necesse", "sidus", "aetās", "ambō", "novemdecim", "anguis", "flagellum", "galēna", "platea", "calx", "tabernaculum", "vulgus", "pagus", "vita", "modulus", "aurum", "vīcēsimus", "porta", "galbus", "octāvus", "centesimus", "laxus", "ancilla", "uterculus", "miraculum", "miles", "ordo", "bulla", "ānellus", "fusticulus", "venula", "gena", "mantellum", "cornū", "ferrum", "mendicus", "corvellus", "astus", "fasciculus", "crus", "noveni", "tempus", "ventulus", "coruscus", "mūs", "pōculum", "alveus", "denticulus", "agrellus", "bucca", "flaccus", "cutis", "terra", "guttur", "damnum", "senex", "piscis", "duodeni", "vulpēcula", "glomus", "frōns", "pannus", "cura", "puer", "vadum", "hērēs", "sal", "inguen", "vāsculum", "celer", "fistula", "follis", "caulis", "capanna", "frenulum", "locus", "joculus", "vēlum", "coxa", "pumex", "pix", "probrum", "rete", "nux", "acus", "ebrius", "vīllula", "columba", "cartilago", "cuculus", "rōstrum", "circus", "longus", "amoenus", "formica", "caudicula", "os", "nāvicula", "crista", "seni", "latus", "saetula", "castellum", "manicula", "formus", "octō", "persona", "candēla", "fruticulus", "pecu", "paucus", "remus", "sincerus", "auris", "floscellus", "superus", "tenuis", "alga", "hortus", "fames", "bacula", "nox", "acula", "particella", "duo", "vacuus", "varius", "umbella", "stirps", "fundulus", "novus", "articulus", "cera", "geniculum", "cardo", "vās", "aedicula", "globulus", "nonageni", "cuticula", "odor", "millēnī", "carrus", "bulbus", "homunculus", "unda", "ovis", "vastus", "vir", "botellus", "campus", "febris", "casa", "frēnum", "quaternī", "homō", "turbula", "stiria", "tabes", "amārus", "templum", "mūrus", "vassus", "pirus", "anas", "falx", "murmur", "ovicula", "rāmus", "portula", "stimulus", "miser", "ulcusculum", "capitulum", "ars", "aestus", "porca", "dexter", "corolla", "rosa", "mons", "laus", "stipella", "pravus", "cūpa", "latex", "cerebellum", "strēnuus", "pauper", "lutum", "as", "foris", "cerebrum", "lingula", "sanguis", "vēna", "cervīx" };
            string[] punctuation = { ".", "!", "?" };
            var x = new System.Text.StringBuilder();
            while (i != NumberOfWords)
            {

                int k = randNum.Next(0, words.Length);

                if (k != placeholder)
                {
                    wordsInSentance++;
                    if (wordsInSentance == 1)
                    {
                        x.Append(UppercaseFirst(words[k]));
                    }
                    else
                    {
                        x.Append(words[k]);
                    }

                    if (wordsInSentance == maxWords)
                    {
                        numberOfSentances++;
                        //if (numberOfSentances == 1)
                        //{
                        //    x.Append(".").Append(" ");
                        //}
                        //else
                        //{
                        var y = randNum.Next(0, punctuation.Length);
                        x.Append(punctuation[y]).Append(" ");
                        //}
                        wordsInSentance = 0;
                        //Set lenght of next sentenance.
                        maxWords = randNum.Next(3, 8);
                        //Increment sentance count

                    }
                    else
                    {
                        x.Append(" ");
                    }

                    placeholder = k;
                    i++;
                }


            }
            return x.ToString();
        }
    }
}
