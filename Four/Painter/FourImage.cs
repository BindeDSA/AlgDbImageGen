using PuzzleImageGenerator.Four.Simulation.Enums;
using PuzzleImageGenerator.Four.Simulation.Pieces;

namespace PuzzleImageGenerator.Four.Painter
{
    class FourImage
    {

        FourImageProp Properties;

        public FourImage(FourImageConfiguration configs)
        {
            Properties = new FourImageProp(configs);
        }

        public string GetSvgText()
        {
            var svgText = "";
            if (Properties.View == ViewType.plan)
            {
                svgText += Properties.SvgPlanHeader;
                svgText += GetPlanStickers();
            }
            else
            {
                svgText += Properties.SvgTransHeader;
                svgText += GetTransStickers();
            }

            svgText += Properties.SvgFooter;
            return svgText;
        }

        private string GetPlanStickers()
        {
            var returnString = "<g style='opacity:1;stroke-opacity:0.5;stroke-width:0;stroke-linejoin:round'>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 0) + "' stroke='#000000'  points='-0.52777777777778,-0.52777777777778 -0.21296296296296,-0.52777777777778 -0.21296296296296,-0.21296296296296 -0.52777777777778,-0.21296296296296'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UB], 0, 0) + "' stroke='#000000'  points='-0.15740740740741,-0.52777777777778 0.15740740740741,-0.52777777777778 0.15740740740741,-0.21296296296296 -0.15740740740741,-0.21296296296296'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 0) + "' stroke='#000000'  points='0.21296296296296,-0.52777777777778 0.52777777777778,-0.52777777777778 0.52777777777778,-0.21296296296296 0.21296296296296,-0.21296296296296'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UL], 0, 0) + "' stroke='#000000'  points='-0.52777777777778,-0.15740740740741 -0.21296296296296,-0.15740740740741 -0.21296296296296,0.15740740740741 -0.52777777777778,0.15740740740741'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.U], 0) + "' stroke='#000000'  points='-0.15740740740741,-0.15740740740741 0.15740740740741,-0.15740740740741 0.15740740740741,0.15740740740741 -0.15740740740741,0.15740740740741'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UR], 0, 0) + "' stroke='#000000'  points='0.21296296296296,-0.15740740740741 0.52777777777778,-0.15740740740741 0.52777777777778,0.15740740740741 0.21296296296296,0.15740740740741'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 0) + "' stroke='#000000'  points='-0.52777777777778,0.21296296296296 -0.21296296296296,0.21296296296296 -0.21296296296296,0.52777777777778 -0.52777777777778,0.52777777777778'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UF], 0, 0) + "' stroke='#000000'  points='-0.15740740740741,0.21296296296296 0.15740740740741,0.21296296296296 0.15740740740741,0.52777777777778 -0.15740740740741,0.52777777777778'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 0) + "' stroke='#000000'  points='0.21296296296296,0.21296296296296 0.52777777777778,0.21296296296296 0.52777777777778,0.52777777777778 0.21296296296296,0.52777777777778'/>\n";
            returnString += "</g>\n";
            returnString += "<g style='opacity:1;stroke-opacity:1;stroke-width:0.02;stroke-linejoin:round'>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 1) + "' stroke='#000000'  points='-0.54406130268199,0.5544061302682 -0.19591315453384,0.5544061302682 -0.18390804597701,0.7183908045977 -0.50804597701149,0.7183908045977'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UF], 0, 1) + "' stroke='#000000'  points='-0.17445721583653,0.5544061302682 0.17369093231162,0.5544061302682 0.16168582375479,0.7183908045977 -0.16245210727969,0.7183908045977'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 2) + "' stroke='#000000'  points='0.19514687100894,0.5544061302682 0.54329501915709,0.5544061302682 0.50727969348659,0.7183908045977 0.18314176245211,0.7183908045977'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 1) + "' stroke='#000000'  points='-0.5544061302682,-0.54406130268199 -0.5544061302682,-0.19591315453384 -0.7183908045977,-0.18390804597701 -0.7183908045977,-0.50804597701149'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UL], 0, 1) + "' stroke='#000000'  points='-0.5544061302682,-0.17445721583653 -0.5544061302682,0.17369093231162 -0.7183908045977,0.16168582375479 -0.7183908045977,-0.16245210727969'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 2) + "' stroke='#000000'  points='-0.5544061302682,0.19514687100894 -0.5544061302682,0.54329501915709 -0.7183908045977,0.50727969348659 -0.7183908045977,0.18314176245211'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 1) + "' stroke='#000000'  points='0.54406130268199,-0.5544061302682 0.19591315453384,-0.5544061302682 0.18390804597701,-0.7183908045977 0.50804597701149,-0.7183908045977'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UB], 0, 1) + "' stroke='#000000'  points='0.17445721583653,-0.5544061302682 -0.17369093231162,-0.5544061302682 -0.16168582375479,-0.7183908045977 0.16245210727969,-0.7183908045977'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 2) + "' stroke='#000000'  points='-0.19514687100894,-0.5544061302682 -0.54329501915709,-0.5544061302682 -0.50727969348659,-0.7183908045977 -0.18314176245211,-0.7183908045977'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 1) + "' stroke='#000000'  points='0.5544061302682,0.54406130268199 0.5544061302682,0.19591315453384 0.7183908045977,0.18390804597701 0.7183908045977,0.50804597701149'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UR], 0, 1) + "' stroke='#000000'  points='0.5544061302682,0.17445721583653 0.5544061302682,-0.17369093231162 0.7183908045977,-0.16168582375479 0.7183908045977,0.16245210727969'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 2) + "' stroke='#000000'  points='0.5544061302682,-0.19514687100894 0.5544061302682,-0.54329501915709 0.7183908045977,-0.50727969348659 0.7183908045977,-0.18314176245211'/>\n";
            returnString += "</g>\n";

            return returnString;
        }


        private string GetTransStickers()
        {
            var returnString = "<g opacity='100%' stroke-opacity='50%' stroke-width='0' stroke-linejoin='round'>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 0) + "'  points='-5.04569469689E-17,-0.75168776095 0.145599066489,-0.688692824955 -2.95274850537E-17,-0.622014965028 -0.145599066489,-0.688692824955'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UB], 0, 0) + "' stroke='#000000'  points='0.172066719303,-0.676896787718 0.326178061866,-0.610218927791 0.180835318225,-0.539525441769 0.0264676528146,-0.610218927791'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UB], 1, 0) + "' stroke='#000000'  points='0.354242561026,-0.597710604979 0.517635148206,-0.527017118958 0.372852798644,-0.451933987021 0.208899817386,-0.527017118958'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 0) + "'  points='0.547445643293,-0.513729923003 0.7209839404,-0.438646791066 0.577122984206,-0.358752056265 0.402663293731,-0.438646791066'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UL], 1, 0) + "' stroke='#000000'  points='-0.172066719303,-0.676896787718 -0.0264676528146,-0.610218927791 -0.180835318225,-0.539525441769 -0.326178061866,-0.610218927791'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.U], 2) + "' stroke='#000000'  points='-2.56047102389E-17,-0.597710604979 0.15436766541,-0.527017118958 -2.07605758694E-18,-0.451933987021 -0.15436766541,-0.527017118958'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.U], 3) + "' stroke='#000000'  points='0.182481881098,-0.513729923003 0.346434862356,-0.438646791066 0.192374328069,-0.358752056265 0.0281142156875,-0.438646791066'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UR], 0, 0) + "' stroke='#000000'  points='0.376354386018,-0.424505558901 0.550814076492,-0.3446108241 0.3974288053,-0.259426658163 0.22229385173,-0.3446108241'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UL], 0, 0) + "' stroke='#000000'  points='-0.354242561026,-0.597710604979 -0.208899817386,-0.527017118958 -0.372852798644,-0.451933987021 -0.517635148206,-0.527017118958'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.U], 1) + "' stroke='#000000'  points='-0.182481881098,-0.513729923003 -0.0281142156875,-0.438646791066 -0.192374328069,-0.358752056265 -0.346434862356,-0.438646791066'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.U], 0) + "' stroke='#000000'  points='2.35094838337E-18,-0.424505558901 0.164260112381,-0.3446108241 2.89950300616E-17,-0.259426658163 -0.164260112381,-0.3446108241'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UR], 1, 0) + "' stroke='#000000'  points='0.194239586624,-0.329530389206 0.369374540194,-0.244346223269 0.205486736611,-0.153329362608 0.0299794742426,-0.244346223269'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 0) + "' stroke='#000000'  points='-0.547445643293,-0.513729923003 -0.402663293731,-0.438646791066 -0.577122984206,-0.358752056265 -0.7209839404,-0.438646791066'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UF], 1, 0) + "' stroke='#000000'  points='-0.376354386018,-0.424505558901 -0.22229385173,-0.3446108241 -0.3974288053,-0.259426658163 -0.550814076492,-0.3446108241'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UF], 0, 0) + "' stroke='#000000'  points='-0.194239586624,-0.329530389206 -0.0299794742426,-0.244346223269 -0.205486736611,-0.153329362608 -0.369374540194,-0.244346223269'/> \n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 0) + "' stroke='#000000'  points='3.40302859588E-17,-0.228229692229 0.175507262368,-0.137212831568 6.44524377819E-17,-0.0397429790556 -0.175507262368,-0.137212831568'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 1) + "' stroke='#000000'  points='0.0149961967595,-0.0138031968 0.190503459128,-0.111273049313 0.184953093367,0.0916942889225 0.0149961967595,0.192935720842'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UR], 1, 1) + "' stroke='#000000'  points='0.220023157769,-0.128233087292 0.383910961352,-0.219249947953 0.373522114246,-0.0200096603103 0.214472792009,0.0747342509432'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UR], 0, 1) + "' stroke='#000000'  points='0.411532751155,-0.235120768973 0.564918022347,-0.32030493491 0.550303051562,-0.124732925566 0.401143904048,-0.0358804813306'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 2) + "' stroke='#000000'  points='0.590819398432,-0.335188296414 0.734680354626,-0.415083031215 0.716368085412,-0.223110218169 0.576204427647,-0.139616287069'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.FR], 0, 1) + "' stroke='#000000'  points='0.0145364846895,0.22798827049 0.184493381297,0.12674683857 0.17928331117,0.317270150269 0.0145364846895,0.421631056747'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.R], 2) + "' stroke='#000000'  points='0.213120842043,0.109178878975 0.37217016428,0.0144349677213 0.362398430426,0.201840080512 0.207910771916,0.299702190673'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.R], 3) + "' stroke='#000000'  points='0.399011973357,-0.00203820324234 0.548171120871,-0.0908906474776 0.534398086808,0.093414883213 0.389240239503,0.185366909548'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.BR], 1, 1) + "' stroke='#000000'  points='0.573389436685,-0.106368360106 0.71355309445,-0.189862291205 0.696264834335,-0.00862446163019 0.559616402622,0.0779371705851'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.FR], 1, 1) + "' stroke='#000000'  points='0.0141041194665,0.454528038186 0.178850945947,0.350167131707 0.173950806753,0.529356801757 0.0141041194665,0.636280875365'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.R], 1) + "' stroke='#000000'  points='0.206638587425,0.332094900087 0.361126245935,0.234232789925 0.351918225167,0.41082685158 0.201738448231,0.511284570136'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.R], 0) + "' stroke='#000000'  points='0.387230808841,0.217254303409 0.532388656145,0.125302277074 0.519386842491,0.299287628043 0.378022788072,0.393848365064'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.BR], 0, 1) + "' stroke='#000000'  points='0.556958681299,0.109321081578 0.693607113012,0.0227594493631 0.677259305415,0.194138243263 0.543956867645,0.283306432547'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DFR], 2) + "' stroke='#000000'  points='0.0136967314043,0.667215371798 0.173543418691,0.56029129819 0.168926353986,0.729129420578 0.0136967314043,0.83814073153'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.DR], 0, 1) + "' stroke='#000000'  points='0.200539166584,0.541803566375 0.35071894352,0.441345847819 0.342027224053,0.608038135137 0.19592210188,0.710641688763'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.DR], 1, 1) + "' stroke='#000000'  points='0.376125585734,0.423945639372 0.517489640153,0.32938490235 0.505196034422,0.493893282849 0.367433866267,0.59063792669'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DRB], 1) + "' stroke='#000000'  points='0.541443584526,0.312978927863 0.674746022296,0.223810738579 0.659263960603,0.386113667853 0.529149978795,0.477487308361'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 1) + "' stroke='#000000'  points='-0.73500658684,-0.414765455071 -0.591145630646,-0.33487072027 -0.576530659861,-0.139298710925 -0.716694317626,-0.222792642025'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UF], 1, 1) + "' stroke='#000000'  points='-0.565290915613,-0.319981263296 -0.411905644421,-0.234797097359 -0.401516797314,-0.035556809716 -0.550675944828,-0.124409253951'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.UF], 0, 1) + "' stroke='#000000'  points='-0.384337886177,-0.218921090548 -0.220450082594,-0.127904229887 -0.214899716834,0.0750631083484 -0.37394903907,-0.0196808029051'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 2) + "' stroke='#000000'  points='-0.190993197283,-0.110940262895 -0.0154859349148,-0.0134704103817 -0.0154859349148,0.193268507261 -0.185442831523,0.0920270753408'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.FL], 1, 0) + "' stroke='#000000'  points='-0.713863261455,-0.189591611695 -0.57369960369,-0.106097680595 -0.559926569626,0.0782078500953 -0.69657500134,-0.00835378211997'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.F], 2) + "' stroke='#000000'  points='-0.548524176772,-0.0906171549394 -0.399365029258,-0.00176471070415 -0.389593295404,0.185640402086 -0.534751142708,0.0936883757512'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.F], 3) + "' stroke='#000000'  points='-0.37257266402,0.0147101029191 -0.213523341784,0.109454014173 -0.208313271656,0.299977325871 -0.362800930167,0.202115215709'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.FR], 0, 0) + "' stroke='#000000'  points='-0.184953093367,0.127022086325 -0.0149961967595,0.228263518245 -0.0149961967595,0.421906304502 -0.17974302324,0.317545398024'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.FL], 0, 0) + "' stroke='#000000'  points='-0.693902347772,0.0229894396927 -0.557253916058,0.109551071908 -0.544252102405,0.283536422877 -0.677554540175,0.194368233593'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.F], 1) + "' stroke='#000000'  points='-0.532723402576,0.125532457429 -0.387565555272,0.217484483764 -0.378357534504,0.394078545419 -0.519721588922,0.299517808397'/>\n";
            returnString += "<polygon fill='" + GetCenterColor(Properties.Cube.Centers[(int)CenterPiece.F], 0) + "' stroke='#000000'  points='-0.361506353133,0.234461814195 -0.207018694623,0.332323924357 -0.202118555429,0.511513594407 -0.352298332365,0.41105587585'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.FR], 1, 0) + "' stroke='#000000'  points='-0.17928331117,0.350393293513 -0.0145364846895,0.454754199991 -0.0145364846895,0.636507037171 -0.174383171976,0.529582963563'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DLF], 2) + "' stroke='#000000'  points='-0.675027356646,0.224005337216 -0.541724918876,0.3131735265 -0.529431313145,0.477681906999 -0.659545294952,0.38630826649'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.DF], 0, 1) + "' stroke='#000000'  points='-0.517807453647,0.329577600011 -0.376443399228,0.424138337032 -0.367751679761,0.590830624351 -0.505513847916,0.49408598051'/>\n";
            returnString += "<polygon fill='" + GetEdgeColor(Properties.Cube.Edges[(int)EdgePiece.DF], 1, 1) + "' stroke='#000000'  points='-0.351078471882,0.441535186207 -0.200898694946,0.541992904763 -0.196281630241,0.710831027152 -0.342386752414,0.608227473526'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DFR], 1) + "' stroke='#000000'  points='-0.173950806753,0.560475466191 -0.0141041194664,0.667399539799 -0.0141041194664,0.838324899531 -0.169333742048,0.729313588579'/>\n";

            returnString += "</g>\n";
            return returnString;
        }

        private string GetCornerColor(Corner piece, int stickerNum)
        {
            if (Properties.Stage.ToLower() == "oll")
            {
                if (piece.Piece.ToString().Contains("U") && piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "coll")
            {
                if (piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocll")
            {
                if (piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ell")
            {
                return Properties.ColorScheme.GetSticker(null);
            }
            else if (Properties.Stage.ToLower() == "f2l")
            {
                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ll")
            {
                if (piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "fl")
            {
                if (piece.Piece.ToString().Contains("D"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cll")
            {
                if (piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "oell")
            {
                return Properties.ColorScheme.GetSticker(null);
            }
            else if (Properties.Stage.ToLower() == "ocell")
            {
                if (piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "wv")
            {
                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "vh")
            {
                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "els")
            {
                if (!piece.Piece.ToString().Contains("U") && piece.Piece != CornerPiece.DFR)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cls")
            {
                if (piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cross")
            {
                return Properties.ColorScheme.GetSticker(null);
            }
            else if (Properties.Stage.ToLower() == "f2b")
            {

                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "line")
            {
                return Properties.ColorScheme.GetSticker(null);
            }

            return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
        }

        private string GetEdgeColor(Edge piece, int pieceNum, int stickerNum)
        {
            if (Properties.Stage.ToLower() == "oll")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "coll")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocll")
            {
                return Properties.ColorScheme.GetSticker(null);
            }
            else if (Properties.Stage.ToLower() == "ell")
            {
                if (piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "f2l")
            {
                if (!piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ll")
            {
                if (piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "fl")
            {
                if (piece.Cubies[pieceNum].ToString().Contains("D"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cll")
            {
                return Properties.ColorScheme.GetSticker(null);
            }
            else if (Properties.Stage.ToLower() == "oell")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocell")
            {
                if (piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "wv")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else if (!piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "vh")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else if (!piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "els")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else if (!piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cls")
            {
                if (piece.GetStickerFace(pieceNum, stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else if (!piece.Cubies[pieceNum].ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cmll")
            {
                if (!piece.Cubies[pieceNum].ToString().Contains("U") && piece.Cubies[pieceNum].Piece != EdgePiece.DF && piece.Cubies[pieceNum].Piece != EdgePiece.DB)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cross")
            {
                if (piece.Cubies[pieceNum].ToString().Contains("D"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "f2b")
            {
                if (!piece.Cubies[pieceNum].ToString().Contains("U") && piece.Cubies[pieceNum].Piece != EdgePiece.DF && piece.Cubies[pieceNum].Piece != EdgePiece.DB)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "line")
            {
                if (piece.Cubies[pieceNum].Piece == EdgePiece.DF || piece.Cubies[pieceNum].Piece == EdgePiece.DB)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }

            return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(pieceNum, stickerNum));
        }

        private string GetCenterColor(Center piece, int pieceNum)
        {
            if (Properties.Stage.ToLower() == "oll")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "coll")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocll")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ell")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "f2l")
            {
                if (piece.ToString() != FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ll")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "fl")
            {
                if (piece.ToString() == FaceType.D.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cll")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "oell")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocell")
            {
                if (piece.ToString() == FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cmll")
            {
                if (piece.ToString() == FaceType.R.ToString() || piece.ToString() == FaceType.L.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cross")
            {
                if (piece.ToString() != FaceType.U.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "f2b")
            {
                if (piece.ToString() == FaceType.R.ToString() || piece.ToString() == FaceType.L.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "line")
            {
                if (piece.ToString() == FaceType.F.ToString() || piece.ToString() == FaceType.B.ToString())
                {
                    return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }

            return Properties.ColorScheme.GetSticker((int)piece.Cubies[pieceNum]);
        }
    }
}
