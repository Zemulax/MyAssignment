﻿namespace MyAssignment
{
    /// <summary>
    /// this class parses and executes all commands
    /// </summary>
    public class CommandParser : Shape
    {
        private readonly Graphics graphics;
        readonly int[] cordinates = new int[5];
        private static Color colour = Color.White;
        readonly Dictionary<string, int> collectVariables = new();
        readonly Variables variables = new();
        private readonly List<string> collectIfStatements = new();
        private readonly List<string> collectedMethods = new();
        private readonly Colours colours = new(colour);
        private readonly Methods methods = new();
        private Shape? shape = null;
        readonly Cursor cursor = new();
        Point generalUsePoints = new();
        PointF pointf = new PointF();
        /// <summary>
        /// empty commandparser constructor
        /// </summary>
        public CommandParser() : base() { }

        /// <summary>
        /// Parsecommander class constructor interprets and executes commands using various method calls
        /// </summary>
        /// <param name="points">the x and y axis to set the pen to a position</param>
        /// <param name="graphics">surface for drawing</param>
        /// <param name="commands">commands that determine execution</param>
        /// <param name="color">color of the shape object</param>
        public CommandParser(Point points, Color color, Graphics graphics, string[] commands) : base(points, color)
        {
            int parameter1;
            int parameter2;
            this.graphics = graphics;

            //used where points are required


            //all commands execution happens in here
            for (int i = 0; i < commands.Length; i++)
            {
                try
                {
                    //checking for methods definition
                    if (commands[i].ToLower().StartsWith("method"))
                    {
                        if (commands[i].ToLower().EndsWith("()"))
                        {
                            try
                            {

                                collectedMethods.Add(commands[i]);
                                i++;
                                if (commands[i].StartsWith(" ")) //method line should be indented
                                {
                                    collectedMethods.Add(commands[i]);
                                    i++;
                                    if (commands[i].Contains("endmethod"))
                                    {
                                        collectedMethods.Add(commands[i]);

                                    }
                                    else
                                    {
                                        Form1.ErrorMessages.Add("Warning: Method not ended properly at line: " + commands[i]);
                                        return;
                                    }
                                }
                                else
                                {
                                    Form1.ErrorMessages.Add("incorrect indentation detected at line: " + commands[i]);
                                    return;

                                }
                            }

                            catch (IndexOutOfRangeException)
                            {
                                IndexOutOfRangeException indexOutOfRangeException = new("A method body is required");
                                Form1.ErrorMessages.Add(indexOutOfRangeException.Message);
                                break;
                            }
                        }
                        else
                        {
                            Form1.ErrorMessages.Add("Warning!! Bad method definition. Missing '()' at line: " + commands[i]);
                            return;
                        }
                        methods.MethodsProcessor(collectedMethods);
                        collectedMethods.Clear();
                        continue;

                    }
                    else if (methods.methodname == null) { } //if method name does not exist move on
                    else if (commands[i].Contains(methods.methodname[1])) //if command matches a method name, call a method and execute its line
                    {
                        commands[i] = methods.methodLines[0];
                    }

                    //this block of code checks for commands that affect drawn shapes
                    switch (commands[i].ToLower())
                    {

                        case "pen red":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Red, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Red);
                            continue;

                        case "pen green":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Green, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Green);
                            continue;

                        case "pen magenta":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Magenta, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Magenta);
                            continue;

                        case "pen yellow":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Yellow, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Yellow);
                            continue;



                        case "default":
                            colour = Color.White;
                            colours.ShapePen = new(Color.White, 5);
                            colours.ShapeBrush = new SolidBrush(Color.White);
                            continue;

                        case "fill on":
                            fill = true;
                            continue;

                        case "fill off":
                            fill = false;
                            continue;

                        case "clear":
                            graphics.Clear(Color.MidnightBlue);
                            continue;

                        case "reset":
                            points.X = 0;
                            points.Y = 0;
                            ShapePoint = points;
                            continue;
                    }

                    //this block executes variable declarations
                    if (commands[i].Contains(" = "))
                    {

                        string[] splitVariable = commands[i].Split('=');
                        if (int.TryParse(splitVariable[1], out int value) == true)
                        {
                            collectVariables.Add(splitVariable[0], int.Parse(splitVariable[1]));
                            variables.VariableProcessor(collectVariables);
                        }
                        else { throw new FormatsException(splitVariable[1].ToString()); }
                        continue;
                    }
                    //variable block ends here

                    //this block executes if-statements
                    else if (commands[i].Contains("if"))
                    {
                        if (commands[i].Contains("if"))
                        {
                            try
                            {

                                collectIfStatements.Add(commands[i]);
                                i++;
                                if (commands[i].Contains(' '))
                                {
                                    collectIfStatements.Add(commands[i]);
                                    i++;

                                    if (commands[i].Contains(' '))
                                    {
                                        collectIfStatements.Add(commands[i]);
                                        i++;
                                        if (commands[i].Contains("endif")) //if statement must end with an endif
                                        {
                                            collectIfStatements.Add(commands[i]);
                                        }
                                        else
                                        {
                                            Form1.ErrorMessages.Add("if statement not ended correctly at line:" + commands[i]);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        Form1.ErrorMessages.Add("incorrect indentation was detected at line: " + commands[i]);
                                        return;
                                    }

                                }
                                //if block ends here
                                else
                                {
                                    Form1.ErrorMessages.Add("incorrect indentation was detected at line:" + commands[i]);
                                    return;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                IndexOutOfRangeException indexOutOfRangeException = new("if statement body required");
                                Form1.ErrorMessages.Add(indexOutOfRangeException.Message);
                                break;

                            }
                        }


                        //this block executes if statements with 2 lines
                        //checks each lines's contents and runs it
                        IfStatements ifStatements = new(collectIfStatements);

                        foreach (string line in IfStatements.Methodlines)
                        {
                            switch (line)
                            {
                                case "rectangle":
                                    shape = ShapeFactory.GetShape("rectangle");
                                    shape.Set(Colour, fill, colours.ShapeBrush, colours.ShapePen, cordinates[3], cordinates[4],
                                        IfStatements.ShapeParameter, IfStatements.ShapeParameter);
                                    shape.DrawShape(graphics);
                                    break;

                                case "circle":
                                    shape = ShapeFactory.GetShape("circle");
                                    shape.Set(Colour, fill, colours.ShapeBrush, colours.ShapePen, cordinates[3], cordinates[4],
                                        IfStatements.ShapeParameter);
                                    shape.DrawShape(graphics);
                                    break;

                                default:
                                    Form1.ErrorMessages.Add("try rectangle or circle for method lines");
                                    break;
                            }
                        }

                        continue;
                    }


                    //this block processes the variables to be used as parameters
                    else if (collectVariables.Count > 0)
                    {
                        string[] splitcommand = commands[i].Split(" "); //check what variable the command owns
                        if (splitcommand.Length > 2) //first sub-block checks if the command contains 2 variables
                        {
                            foreach (KeyValuePair<string, int> pair in collectVariables)
                            {
                                if (pair.Key.Contains(splitcommand[1]))
                                {
                                    parameter1 = pair.Value;
                                    cordinates[0] = parameter1;
                                }
                                else if (pair.Key.Contains(splitcommand[2]))
                                {
                                    parameter2 = pair.Value;
                                    cordinates[1] = parameter2;
                                }
                            }
                            generalUsePoints.X = cordinates[0];
                            generalUsePoints.Y = cordinates[1];
                            cordinates[3] = ShapePoint.X;
                            cordinates[4] = ShapePoint.Y;

                        }
                        else //if command contains a single variable
                        {
                            foreach (KeyValuePair<string, int> pair in collectVariables)
                            {
                                if (pair.Key.Contains(splitcommand[1]))
                                {
                                    parameter1 = pair.Value;
                                    parameter2 = pair.Value;
                                    cordinates[0] = parameter1;
                                    cordinates[1] = parameter2;

                                    generalUsePoints.X = cordinates[0];
                                    generalUsePoints.Y = cordinates[1];
                                    cordinates[3] = ShapePoint.X;
                                    cordinates[4] = ShapePoint.Y;
                                }
                            }
                        }

                        ShapesMethod(splitcommand[0].ToLower()); //draw shapes according to the command
                        continue;
                    }

                    else //this section executes commands that do not own variables as parameters
                    {
                        string[] separators = { " ", "," };
                        IEnumerable<string> values = commands[i].Split(separators, StringSplitOptions.RemoveEmptyEntries); //split the first item in the array by two delimiters
                        string firstCommand = values.First().ToLower();

                        if (int.TryParse(values.Skip(1).First(), out int value) != true)
                        {
                            throw new FormatsException(commands[i]); //THIS
                        }
                        else if (values.Skip(1).First() == null)
                        {
                            throw new FormatException(commands[i]);
                        }
                        else
                        {
                            parameter1 = int.Parse(values.Skip(1).First()); //skip the first value which is the "firstCommand",get the second value
                            parameter2 = int.Parse(values.Last());
                            cordinates[0] = parameter1;
                            cordinates[1] = parameter2;
                            generalUsePoints.X = cordinates[0];
                            generalUsePoints.Y = cordinates[1];

                            cordinates[3] = ShapePoint.X;
                            cordinates[4] = ShapePoint.Y;

                            ShapesMethod(firstCommand);
                        }
                    }
                }

                catch (NullReferenceException e)
                {
                    FormatsException.InvalidMethodDefinitionException(e);
                }

                catch (FormatsException ex)
                {
                    FormatsException.InvalidParameterException(ex);
                }


                catch (InvalidOperationException e)
                {
                    FormatsException.MissingParameterException(e);
                }

                catch (ArgumentOutOfRangeException e)
                {
                    FormatsException.ValueOutOfRangeException(e);
                }


            }
        }




        /// <summary>
        /// this method processes draw commands
        /// passes them to the shape factory
        /// to draw the necessary object
        /// </summary>
        /// <param name="command">the draw command to be used to draw a shape</param>
        public void ShapesMethod(string command)
        {
            PointF pt1 = new(40.0F, 50.0F);
            PointF pt2 = new(60.0F, 70.0F);
            PointF pt3 = new(80.0F, 34.0F);
            PointF pt4 = new(120.0F, 180.0F);
            PointF pt5 = new(200.0F, 150.0F);
            PointF pt6 = new(100.0F, 267.0F);
            PointF[] polygonPoints =
            {
                pt1, pt2, pt3, pt4,pt5
            };
            switch (command)
            {
                case "circle":
                    shape = ShapeFactory.GetShape("circle");
                    shape.Set(Colour, fill, colours.ShapeBrush, colours.ShapePen, cordinates[3], cordinates[4], cordinates[0]);
                    shape.DrawShape(graphics);
                    break;

                case "rectangle":
                    shape = ShapeFactory.GetShape("rectangle");
                    shape.Set(Colour, fill, colours.ShapeBrush, colours.ShapePen, ShapePoint.X, ShapePoint.Y, cordinates[0], cordinates[1]);
                    shape.DrawShape(graphics);
                    break;

                case "triangle":
                    shape = ShapeFactory.GetShape("triangle");
                    shape.Set(Colour, fill, colours.ShapeBrush, colours.ShapePen, cordinates[3], cordinates[4], cordinates[1]);
                    shape.DrawShape(graphics);
                    break;

                case "moveto":
                    cursor.Points = generalUsePoints;
                    ShapePoint = cursor.Points;
                    break;

                case "drawto":
                    shape = ShapeFactory.GetShape("drawto");
                    shape.Set(Colour, fill, colours.ShapeBrush, colours.ShapePen, cordinates[0], cordinates[1]);
                    shape.DrawShape(graphics);
                    break;

                case "multishapes":
                    graphics.DrawRectangle(ShapePen, 100, 50, 100, 120);
                    graphics.DrawPolygon(ShapePen, polygonPoints);
                    break;

                default:
                    Form1.ErrorMessages.Add("Unrecognised command at: " + command);
                    return;
            }
        }

        /// <summary>
        /// sets and gets the coordiated into the array
        /// </summary>
        public int[] Cordinates
        {
            get { return cordinates; }
        }

        /// <summary>
        /// unimplemented method
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="fill"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void DrawShape(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// sets the value of fill to true or false
        /// </summary>
        public bool Fill
        {
            get { return fill; }

        }


        /// <summary>
        /// color property used by the color class
        /// sets and gets the colour
        /// </summary>
        public static Color Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
