using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jonas Spohr
/// </summary>

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running...");
            execute("maxslicesum");
            Console.WriteLine("Finished...");
            Console.ReadLine();
        }

        /// <summary>
        /// Run the lesson you passed on method parameter
        /// </summary>
        /// <param name="method">Name of the method you want to execute</param>
        public static void execute(string method)
        {
            switch (method)
            {
                case "binarygap": // 100%
                    BinaryGap bg = new BinaryGap();
                    var retBG = bg.run(15);
                    Console.WriteLine("BinaryGap Result for 15 is: " + retBG);
                    retBG = bg.run(9);
                    Console.WriteLine("BinaryGap Result for 9 is: " + retBG);
                    retBG = bg.run(529);
                    Console.WriteLine("BinaryGap Result for 529 is: " + retBG);
                    retBG = bg.run(1041);
                    Console.WriteLine("BinaryGap Result for 1041 is: " + retBG);
                    break;

                case "oddoccurrencesinarray": // 100%
                    OddOccurrencesInArray odd = new OddOccurrencesInArray();
                    var retODD = odd.run(new int[] { 9, 3, 9, 3, 9, 7, 9 });
                    Console.WriteLine("OddOccurrencesInArray Result is: " + retODD);
                    retODD = odd.run(new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 1, 1, 1 });
                    Console.WriteLine("OddOccurrencesInArray Result is: " + retODD);
                    break;

                case "cyclicrotation": // 100%
                    CyclicRotation cycli = new CyclicRotation();
                    var retCYCLI = cycli.run(new int[] { -9, 0 }, 2);
                    Console.WriteLine("CyclicRotation Result is: " + string.Join(",", retCYCLI.Select(p => p.ToString()).ToArray()));
                    retCYCLI = cycli.run(new int[] { 3, 8, 9, 7, 6 }, 3);
                    Console.WriteLine("CyclicRotation Result is: " + string.Join(",", retCYCLI.Select(p => p.ToString()).ToArray()));
                    break;

                case "permmissingelem": // 100%
                    PermMissingElem missingElement = new PermMissingElem();
                    var retMISSINGELEMENT = missingElement.run(new int[] { 2, 3, 1, 5 });
                    Console.WriteLine("PermMissingElem Result is: " + retMISSINGELEMENT);
                    break;

                case "frogjmp": // 100%
                    FrogJmp frog = new FrogJmp();
                    var retFROG = frog.run(10, 85, 30);
                    Console.WriteLine("FrogJmp Result is: " + retFROG);
                    break;

                case "tapeequilibrium": // 100%
                    TapeEquilibrium tape = new TapeEquilibrium();
                    var retTAPE = tape.run(new int[] { 3, 1, 2, 4, 3 });
                    Console.WriteLine("TapeEquilibrium Result is: " + retTAPE);
                    break;

                case "missinginteger": // 100%
                    MissingInteger missInteger = new MissingInteger();
                    var retMISSINTEGER = missInteger.run(new int[] { 1, 3, 6, 4, 1, 2 });
                    Console.WriteLine("MissingInteger Result is: " + retMISSINTEGER);
                    break;

                case "permcheck": // 100%
                    PermCheck permCheck = new PermCheck();
                    var retPERMCHECK = permCheck.run(new int[] { 4, 1, 3, 2 });
                    Console.WriteLine("PermCheck Result is: " + retPERMCHECK);
                    break;

                case "frogriverone": // 100%
                    FrogRiverOne frogRiverOne = new FrogRiverOne();
                    var retFROGRIVERONE = frogRiverOne.run(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
                    Console.WriteLine("FrogRiverOne Result is: " + retFROGRIVERONE);
                    break;

                case "maxcounters": // 100%
                    MaxCounters maxCounters = new MaxCounters();
                    var retMAXCOUNTERS = maxCounters.run(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
                    Console.WriteLine("MaxCounters Result is: " + string.Join(",", retMAXCOUNTERS.Select(p => p.ToString()).ToArray()));
                    break;

                case "countdiv": // 100%
                    CountDiv countDiv = new CountDiv();
                    var retCOUNTDIV = countDiv.run(6, 11, 2);
                    Console.WriteLine("CountDiv Result is: " + retCOUNTDIV);
                    break;

                case "passingcars": // 100%
                    PassingCars passingCars = new PassingCars();
                    var retPASSINGCARS = passingCars.run(new int[] { 0, 1, 0, 1, 1 });
                    Console.WriteLine("PassingCars Result is: " + retPASSINGCARS);
                    break;

                case "genomicrangequery": // 62%
                    GenomicRangeQuery genomyc = new GenomicRangeQuery();
                    var retGENOMYC = genomyc.run("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 });
                    Console.WriteLine("GenomicRangeQuery Result is: " + string.Join(",", retGENOMYC.Select(p => p.ToString()).ToArray()));
                    break;

                case "minavgtwoslice": // 100%
                    MinAvgTwoSlice minavg = new MinAvgTwoSlice();
                    var retMINAVG = minavg.run(new int[] { 4, 2, 2, 5, 1, 5, 8 });
                    Console.WriteLine("MinAvgTwoSlice Result is: " + retMINAVG);
                    break;

                case "distinct": // 100%
                    Distinct dist = new Distinct();
                    var retDIST = dist.run(new int[] { 2, 1, 1, 2, 3, 1 });
                    Console.WriteLine("MinAvgTwoSlice Result is: " + retDIST);
                    break;

                case "maxproductofthree": // 100%
                    MaxProductOfThree max3 = new MaxProductOfThree();
                    var retMAX3 = max3.run(new int[] { -3, 1, 2, -2, 5, 6 });
                    Console.WriteLine("MaxProductOfThree Result is: " + retMAX3);
                    break;

                case "triangle": // 90%
                    Triangle triangle = new Triangle();
                    var retTRIANGLE = triangle.run(new int[] { 2147483647, 2147483647, 2147483647 });
                    Console.WriteLine("Triangle Result is: " + retTRIANGLE);
                    break;

                case "numberofdiscintersections": // 100%
                    NumberOfDiscIntersections maxDisc = new NumberOfDiscIntersections();
                    var retMAXDISC = maxDisc.run(new int[] { 1, 5, 2, 1, 4, 0 });
                    Console.WriteLine("NumberOfDiscIntersections Result is: " + retMAXDISC);
                    break;

                case "brackets": // 100%
                    Brackets brackets = new Brackets();
                    var retBRACKETS = brackets.run("{[()()]}");
                    Console.WriteLine("Brackets Result is: " + retBRACKETS);
                    break;

                case "fish": // 100%
                    Fish fish = new Fish();
                    var retFISH = fish.run(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 });
                    Console.WriteLine("Fish Result is: " + retFISH);
                    break;

                case "nesting": // 100%
                    Nesting nest = new Nesting();
                    var retNEST = nest.run("(()(())())");
                    Console.WriteLine("Nesting Result is: " + retNEST);
                    break;

                case "stonewall": // 100%
                    StoneWall stone = new StoneWall();
                    var retSTONE = stone.run(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });
                    Console.WriteLine("StoneWall Result is: " + retSTONE);
                    break;

                case "dominator": // 100%
                    Dominator dominator = new Dominator();
                    var retDOMINATOR = dominator.run(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 });
                    Console.WriteLine("Dominator Result is: " + retDOMINATOR);
                    break;

                case "maxdoubleslicesum": // 100%
                    MaxDoubleSliceSum maxDouble = new MaxDoubleSliceSum();
                    var retMAXDOUBLE = maxDouble.run(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 });
                    Console.WriteLine("MaxDoubleSliceSum Result is: " + retMAXDOUBLE);
                    break;

                case "maxprofit": // 100%
                    MaxProfit maxProfit = new MaxProfit();
                    var retMAXPROFIT = maxProfit.run(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 });
                    Console.WriteLine("MaxProfit Result is: " + retMAXPROFIT);
                    break;

                case "maxslicesum": // 100%
                    MaxSliceSum maxSlice = new MaxSliceSum();
                    var retMAXSLICE = maxSlice.run(new int[] { 3, 2, -6, 4, 0 });
                    Console.WriteLine("MaxSliceSum Result is: " + retMAXSLICE);
                    break;

                default:
                    Console.WriteLine(method + " not found :(");
                    break;
            }
        }
    }
}

