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
            execute("genomicrangequery");
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

                default:
                    Console.WriteLine(method + " not found :(");
                    break;
            }
        }
    }
}

