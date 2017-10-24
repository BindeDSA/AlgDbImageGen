using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Pyra.Painter
{
    class SvgGenerator
    {
        PyraImageProp Properties;

        public SvgGenerator(PyraImageConfiguration configs)
        {
            Properties = new PyraImageProp(configs)
            {
                ImageSize = new Tuple<double, double>(540, 540)
            };
        }

        public string GetSvgText()
        {
            var svgText = SvgHelper.GetHeader(Properties);

            var one = new List<CoordPair>();
            var one1 = new CoordPair(270, 10);
            one.Add(one1);
            var one2 = CoordPair.CartesianFromPolar(60, Math.PI * 330 / 180, one1);
            one.Add(one2);
            var one3 = CoordPair.CartesianFromPolar(60, Math.PI * 30 / 180, one1);
            one.Add(one3);
            svgText += SvgHelper.GetPolygonText(one.ToArray(), width: 2);

            var two = new List<CoordPair>();
            var two1 = one2;
            two.Add(two1);
            var two2 = CoordPair.CartesianFromPolar(60, Math.PI * 330 / 180, two1);
            two.Add(two2);
            var two3 = CoordPair.CartesianFromPolar(60, Math.PI * 30 / 180, two1);
            two.Add(two3);
            svgText += SvgHelper.GetPolygonText(two.ToArray(), width: 2);

            var three = new List<CoordPair>();
            var three1 = one3;
            three.Add(three1);
            var three2 = CoordPair.CartesianFromPolar(60, Math.PI * 330 / 180, three1);
            three.Add(three2);
            var three3 = CoordPair.CartesianFromPolar(60, Math.PI * 30 / 180, three1);
            three.Add(three3);
            svgText += SvgHelper.GetPolygonText(three.ToArray(), width: 2);

            var four = new List<CoordPair>
            {
                one2,
                one3,
                two3
            };
            svgText += SvgHelper.GetPolygonText(four.ToArray(), width: 2);

            var five = new List<CoordPair>();
            var five1 = two2;
            five.Add(five1);
            var five2 = CoordPair.CartesianFromPolar(60, Math.PI * 330 / 180, five1);
            five.Add(five2);
            var five3 = CoordPair.CartesianFromPolar(60, Math.PI * 30 / 180, five1);
            five.Add(five3);
            svgText += SvgHelper.GetPolygonText(five.ToArray(), width: 2);

            var six = new List<CoordPair>();
            var six1 = two3;
            six.Add(six1);
            var six2 = CoordPair.CartesianFromPolar(60, Math.PI * 330 / 180, six1);
            six.Add(six2);
            var six3 = CoordPair.CartesianFromPolar(60, Math.PI * 30 / 180, six1);
            six.Add(six3);
            svgText += SvgHelper.GetPolygonText(six.ToArray(), width: 2);

            var seven = new List<CoordPair>();
            var seven1 = three3;
            seven.Add(seven1);
            var seven2 = CoordPair.CartesianFromPolar(60, Math.PI * 330 / 180, seven1);
            seven.Add(seven2);
            var seven3 = CoordPair.CartesianFromPolar(60, Math.PI * 30 / 180, seven1);
            seven.Add(seven3);
            svgText += SvgHelper.GetPolygonText(seven.ToArray(), width: 2);

            var eight = new List<CoordPair>
            {
                two2,
                two3,
                five3
            };
            svgText += SvgHelper.GetPolygonText(eight.ToArray(), width: 2);

            var nine = new List<CoordPair>
            {
                three2,
                three3,
                six3
            };
            svgText += SvgHelper.GetPolygonText(nine.ToArray(), width: 2);

            var ten = new List<CoordPair>();
            var ten1 = five2;
            ten.Add(ten1);
            var ten2 = five3;
            ten.Add(ten2);
            var ten3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (90 - 25.65890) / 180, ten1);
            ten.Add(ten3);
            svgText += SvgHelper.GetPolygonText(ten.ToArray(), width: 2);

            var eleven = new List<CoordPair>();
            var eleven1 = six2;
            eleven.Add(eleven1);
            var eleven2 = six3;
            eleven.Add(eleven2);
            var eleven3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (90 - 25.65890) / 180, eleven1);
            eleven.Add(eleven3);
            svgText += SvgHelper.GetPolygonText(eleven.ToArray(), width: 2);

            var twelve = new List<CoordPair>();
            var twelve1 = seven2;
            twelve.Add(twelve1);
            var twelve2 = seven3;
            twelve.Add(twelve2);
            var twelve3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (90 - 25.65890) / 180, twelve1);
            twelve.Add(twelve3);
            svgText += SvgHelper.GetPolygonText(twelve.ToArray(), width: 2);

            var thirteen = new List<CoordPair>
            {
                ten2,
                ten3,
                eleven3
            };
            svgText += SvgHelper.GetPolygonText(thirteen.ToArray(), width: 2);

            var fourteen = new List<CoordPair>
            {
                eleven2,
                eleven3,
                twelve3
            };
            svgText += SvgHelper.GetPolygonText(fourteen.ToArray(), width: 2);

            var fifteen = new List<CoordPair>();
            var fifteen1 = ten3;
            fifteen.Add(fifteen1);
            var fifteen2 = eleven3;
            fifteen.Add(fifteen2);
            var fifteen3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (90 - 25.65890) / 180, fifteen1);
            fifteen.Add(fifteen3);
            svgText += SvgHelper.GetPolygonText(fifteen.ToArray(), width: 2);

            var sixteen = new List<CoordPair>();
            var sixteen1 = eleven3;
            sixteen.Add(sixteen1);
            var sixteen2 = twelve3;
            sixteen.Add(sixteen2);
            var sixteen3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (90 - 25.65890) / 180, sixteen1);
            sixteen.Add(sixteen3);
            svgText += SvgHelper.GetPolygonText(sixteen.ToArray(), width: 2);

            var seventeen = new List<CoordPair>
            {
                fifteen2,
                fifteen3,
                sixteen3
            };
            svgText += SvgHelper.GetPolygonText(seventeen.ToArray(), width: 2);

            var eighteen = new List<CoordPair>();
            var eighteen1 = fifteen3;
            eighteen.Add(eighteen1);
            var eighteen2 = sixteen3;
            eighteen.Add(eighteen2);
            var eighteen3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (90 - 25.65890) / 180, eighteen1);
            eighteen.Add(eighteen3);
            svgText += SvgHelper.GetPolygonText(eighteen.ToArray(), width: 2);

            var nineteen = new List<CoordPair>();
            var nineteen1 = one1;
            nineteen.Add(nineteen1);
            var nineteen2 = one3;
            nineteen.Add(nineteen2);
            var nineteen3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (30 + 25.65890) / 180, nineteen1);
            nineteen.Add(nineteen3);
            svgText += SvgHelper.GetPolygonText(nineteen.ToArray(), width: 2);

            var twenty = new List<CoordPair>();
            var twenty1 = three1;
            twenty.Add(twenty1);
            var twenty2 = three3;
            twenty.Add(twenty2);
            var twenty3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (30 + 25.65890) / 180, twenty1);
            twenty.Add(twenty3);
            svgText += SvgHelper.GetPolygonText(twenty.ToArray(), width: 2);

            var twentyone = new List<CoordPair>();
            var twentyone1 = seven1;
            twentyone.Add(twentyone1);
            var twentyone2 = seven3;
            twentyone.Add(twentyone2);
            var twentyone3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (30 + 25.65890) / 180, twentyone1);
            twentyone.Add(twentyone3);
            svgText += SvgHelper.GetPolygonText(twentyone.ToArray(), width: 2);

            var twentytwo = new List<CoordPair>
            {
                nineteen2,
                nineteen3,
                twenty3
            };
            svgText += SvgHelper.GetPolygonText(twentytwo.ToArray(), width: 2);

            var twentythree = new List<CoordPair>
            {
                twenty2,
                twenty3,
                twentyone3
            };
            svgText += SvgHelper.GetPolygonText(twentythree.ToArray(), width: 2);

            var twentyfour = new List<CoordPair>();
            var twentyfour1 = nineteen3;
            twentyfour.Add(twentyfour1);
            var twentyfour2 = twenty3;
            twentyfour.Add(twentyfour2);
            var twentyfour3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (30 + 25.65890) / 180, twentyfour1);
            twentyfour.Add(twentyfour3);
            svgText += SvgHelper.GetPolygonText(twentyfour.ToArray(), width: 2);

            var twentyfive = new List<CoordPair>();
            var twentyfive1 = twenty3;
            twentyfive.Add(twentyfive1);
            var twentyfive2 = twentyone3;
            twentyfive.Add(twentyfive2);
            var twentyfive3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (30 + 25.65890) / 180, twentyfive1);
            twentyfive.Add(twentyfive3);
            svgText += SvgHelper.GetPolygonText(twentyfive.ToArray(), width: 2);

            var twentysix = new List<CoordPair>
            {
                twentyfour2,
                twentyfour3,
                twentyfive3
            };
            svgText += SvgHelper.GetPolygonText(twentysix.ToArray(), width: 2);

            var twentyseven = new List<CoordPair>();
            var twentyseven1 = twentyfour3;
            twentyseven.Add(twentyseven1);
            var twentyseven2 = twentyfive3;
            twentyseven.Add(twentyseven2);
            var twentyseven3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (30 + 25.65890) / 180, twentyseven1);
            twentyseven.Add(twentyseven3);
            svgText += SvgHelper.GetPolygonText(twentyseven.ToArray(), width: 2);

            var twentyeight = new List<CoordPair>();
            var twentyeight1 = one1;
            twentyeight.Add(twentyeight1);
            var twentyeight2 = one2;
            twentyeight.Add(twentyeight2);
            var twentyeight3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (330 - 25.65890) / 180, twentyeight1);
            twentyeight.Add(twentyeight3);
            svgText += SvgHelper.GetPolygonText(twentyeight.ToArray(), width: 2);

            var twentynine = new List<CoordPair>();
            var twentynine1 = two1;
            twentynine.Add(twentynine1);
            var twentynine2 = two2;
            twentynine.Add(twentynine2);
            var twentynine3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (330 - 25.65890) / 180, twentynine1);
            twentynine.Add(twentynine3);
            svgText += SvgHelper.GetPolygonText(twentynine.ToArray(), width: 2);

            var thirty = new List<CoordPair>();
            var thirty1 = five1;
            thirty.Add(thirty1);
            var thirty2 = five2;
            thirty.Add(thirty2);
            var thirty3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (330 - 25.65890) / 180, thirty1);
            thirty.Add(thirty3);
            svgText += SvgHelper.GetPolygonText(thirty.ToArray(), width: 2);

            var thirtyone = new List<CoordPair>
            {
                twentyeight2,
                twentyeight3,
                twentynine3
            };
            svgText += SvgHelper.GetPolygonText(thirtyone.ToArray(), width: 2);

            var thirtyrwo = new List<CoordPair>
            {
                twentynine2,
                twentynine3,
                thirty3
            };
            svgText += SvgHelper.GetPolygonText(thirtyrwo.ToArray(), width: 2);

            var thirtythree = new List<CoordPair>();
            var thirtythree1 = twentyeight3;
            thirtythree.Add(thirtythree1);
            var thirtythree2 = twentynine3;
            thirtythree.Add(thirtythree2);
            var thirtythree3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (330 - 25.65890) / 180, thirtythree1);
            thirtythree.Add(thirtythree3);
            svgText += SvgHelper.GetPolygonText(thirtythree.ToArray(), width: 2);

            var thirtyfour = new List<CoordPair>();
            var thirtyfour1 = twentynine3;
            thirtyfour.Add(thirtyfour1);
            var thirtyfour2 = thirty3;
            thirtyfour.Add(thirtyfour2);
            var thirtyfour3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (330 - 25.65890) / 180, thirtyfour1);
            thirtyfour.Add(thirtyfour3);
            svgText += SvgHelper.GetPolygonText(thirtyfour.ToArray(), width: 2);

            var thirtyfive = new List<CoordPair>
            {
                thirtythree2,
                thirtythree3,
                thirtyfour3
            };
            svgText += SvgHelper.GetPolygonText(thirtyfive.ToArray(), width: 2);

            var thirtysix = new List<CoordPair>();
            var thirtysix1 = thirtythree3;
            thirtysix.Add(thirtysix1);
            var thirtysix2 = thirtyfour3;
            thirtysix.Add(thirtysix2);
            var thirtysix3 = CoordPair.CartesianFromPolar(33.282, Math.PI * (330 - 25.65890) / 180, thirtysix1);
            thirtysix.Add(thirtysix3);
            svgText += SvgHelper.GetPolygonText(thirtysix.ToArray(), width: 2);

            svgText += SvgHelper.GetFooter();

            var stuff = Regex.Matches(svgText, @"[\d]+[.]?[\d]+,[\d]+[.]?[\d]+")
            .Cast<Match>()
            .Select(m => m.Value)
            .Select(m => m.Split(','))
            .Select(m => new double[] { Convert.ToDouble(m[0]), Convert.ToDouble(m[1]) });

            return svgText;
        }
    }
}
