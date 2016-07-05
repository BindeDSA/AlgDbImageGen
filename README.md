##Non NxN Cube Image Generator
<table>
    <tbody>
        <tr>
            <th>Command</th>
            <th>Options</th>
            <th>Default</th>
            <th>Comment</th>
        </tr>
        <tr>
            <td>puzzle</td>
            <td>
                <ul>
                    <li>sq1 - Sqaure-1</li>
                    <li>skewb - Skewb</li>
                    <li>mega - Megaminx</li>
                </ul>
            </td>
            <td>None</td>
            <td width="40%"> Determines puzzle image to be generated, if this command does not exist or contain a valid value, no image will be generated. </td>
        </tr>
        <tr>
            <td>stickers</td>
            <td> </td>
            <td>None</td>
            <td width="40%"> Defines each sticker manually. </td>
        </tr>
        <tr>
            <td>alg</td>
            <td> </td>
            <td>None</td>
            <td width="40%"> Preforms the provided alg on a solved puzzle and outputs resulting state. will override case, but will not override any specifics definitions to stickers. Currently not applicable to megaminx. </td>
        </tr>
        <tr>
            <th>Skewb</th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
        <tr>
            <td>dface</td>
            <td>N/A</td>
            <td>None</td>
            <td width="40%"> If command is present the bottom face of the skewb will be displated, value does not matter.  </td>
        </tr>
        <tr>
            <th>Megaminx</th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
        <tr>
            <td>scheme</td>
            <td></td>
            <td>grey,lime,FB8C00,lightblue,palegoldenrod,deeppink</td>
            <td width="40%"> Changes color scheme,  html colors seperated by commas. in the order  </td>
        </tr>
         <tr>
            <th>Sqaure-1</th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
        <tr>
            <td>transform</td>
            <td></td>
            <td>horizontal</td>
            <td width="40%"> Determines the placement of the down face, horizontal places the down face to the right of the up face, vertical places the down face below.  </td>
        </tr><tr>
            <td>facespacer</td>
            <td></td>
            <td>5</td>
            <td width="40%"> Add blank space between the faces. Deafult is 5 / 100.</td>
        </tr></tbody>
</table>
#Sticker Defs
![alt text](http://i.imgur.com/po83LvS.jpg "Logo Title Text 1")
