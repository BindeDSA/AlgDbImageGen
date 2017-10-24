using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Shared;
using Pyra.Painter;

namespace PuzzleImageGenerator.Pyra.Painter
{
    public class PyraImageProp : ImageProp
    {
        public ColorScheme ColorScheme;

        public string SvgHeader = @"<?xml version='1.0' encoding='UTF-8'?>
                                         <!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.0//EN'
                                         'http://www.w3.org/TR/2001/REC-SVG-20050904/DTD/svg11.dtd'>
                                         <svg xmlns='http://www.w3.org/2000/svg' version='1.1' xmlns:xlink='http://www.w3.org/1999/xlink' width='490' height='420.69219392'>
                                         <defs>
                                         <g id='stickerA' transform='scale(1, 0.577350269)'>
                                        <path
                                        d='m 0,1.732050808 1,-1.732050808 1,1.732050808 z'
                                        stroke='black' stroke-width='0.04px' stroke-linecap='butt' stroke-linejoin='round'
                                        />
                                        </g>
                                        <g id='stickerV' transform='scale(1, 0.577350269)'>
                                        <path
                                        d='m 0,0 1,1.732050808 1,-1.732050808 z'
                                        stroke='black' stroke-width='0.04px' stroke-linecap='butt' stroke-linejoin='round'
                                        />
                                        </g>
                                        </defs>
                                        ";
        public string SvgFooter = @"</svg>";

        public PyraImageProp(PyraImageConfiguration configs)
            : base(configs)
        {
            AddColorScheme(configs.ColorScheme);
        }

        private void AddColorScheme(string schemeString)
        {
            if (schemeString != null)
            {
                schemeString = schemeString.Replace(" ", "")
                                           .Replace("%20", "");
                ColorScheme = new ColorScheme(schemeString.Split('-'));

            }
            else
            {
                ColorScheme = new ColorScheme();
            }
        }
    }
}
