using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Three.Simulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleImageGenerator.Three.Painter
{
    public class ThreeImageProp : ImageProp
    {
        public ViewType View { get; set; }
        public VirtualCube Cube { get; set; }
        public ColorScheme ColorScheme { get; set; }

        public string SvgTransHeader = @"<?xml version='1.0' standalone='no'?>
                                            <!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 
                                            'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'>

                                            <svg version='1.1' xmlns='http://www.w3.org/2000/svg'
                                    	    width='128' height='128'
                        	                viewBox='-0.9 -0.9 1.8 1.8'>
                                           	<g stroke-width='0.1' stroke-linejoin='round' opacity='100%'>
		                                    <polygon fill='#000000' stroke='#000000' points='-4.9165444344952E-17,-0.71734170954349 0.70405037145575,-0.41272706360467 6.3108540577985E-17,-0.021725090572532 -0.70405037145575,-0.41272706360467'/>
		                                    <polygon fill='#000000' stroke='#000000' points='6.3108540577985E-17,-0.021725090572532 0.70405037145575,-0.41272706360467 0.62948028357061,0.36901272915735 5.5589468959362E-17,0.81107056444244'/>
		                                    <polygon fill='#000000' stroke='#000000' points='-0.70405037145575,-0.41272706360467 6.3108540577985E-17,-0.021725090572532 5.5589468959362E-17,0.81107056444244 -0.62948028357061,0.36901272915735'/>
	                                        </g>
                                            ";
        public string SvgPlanHeader = @"<?xml version='1.0' standalone='no'?>
                                                <!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN'
                                                'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'>
                                                
                                                <svg version='1.1' xmlns='http://www.w3.org/2000/svg'
	                                            width='200' height='200'
	                                            viewBox='-0.9 -0.9 1.8 1.8'>
	                                            <rect fill='#FFFFFF' x='-0.9' y='-0.9' width='1.8' height='1.8'/>
	                                            <g style='stroke-width:0.1;stroke-linejoin:round;opacity:1'>
		                                        <polygon fill='#000000' stroke='#000000' points='-0.52222222222222,-0.52222222222222 0.52222222222222,-0.52222222222222 0.52222222222222,0.52222222222222 -0.52222222222222,0.52222222222222'/>
	                                            </g>";
        public string SvgFooter = @"</svg>";

        public ThreeImageProp(ThreeImageConfiguration configs)
            :base(configs)
        {
            View = configs.View;
            Cube = configs.Cube;
            Stage = configs.Stage;

            ColorScheme = new ColorScheme();


            if (configs.ColorScheme != null)
            {
                configs.ColorScheme = configs.ColorScheme.Replace(" ", "")
                                           .Replace("%20", "");
                ColorScheme = new ColorScheme(configs.ColorScheme.Split('-'));

            }
        }
    }
}
