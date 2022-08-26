
namespace retinaIssues{
    class humanRetina{
        public static void generalSymptoms{
            majorSymptoms = ["Seeking specks or cobwebs","Blurred vision","Defects in side vision","Lost vision either temporarily or completely"]
            Console.WriteLine(majorSymptoms)

        }
        public static void retinalTear{
            atRisk = ["Being nearsighted","Having glaucoma","Having a severe eye injury","Condition being present in the genetics","Thin spots present in the retina"]
            symptoms = ["Sudden blurry vision","Increased floaters","Sudden decreases in vision","Signs of headaches"]
            occurances = ["Seeing flashing lights","Seeing too many floaters","Shadow apperance in vision called side vision.","Appearance of a grey curtain"]
            treatments = ["Laser surgery (photocoagulation)","Freezing treatment (cryopexy)","Consult a physician to consult this condition."]
            associatedConditions = ["Diabetes","Sickle cell disease","scar tissue","nearsightedness","former eye trauma","history of condition","retinal degeneration","inflammatory disorders","autoimmune diseases","certain cancers"]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[0]:
            Console.WriteLine("The patient is potentially at risk of" + associatedConditions[0] + ".")
            Console.WriteLine("Because of this symptom" + treatments[2] + ".")
            if symptoms[1]:
            Console.WriteLine("Because of this symptom, you may possibly have the following:" + associatedConditions[0] + "," + associatedConditions[3] + ", and " + associatedConditions[6] + ".")
            Console.WriteLine("With this condition, you should" + treatments[2])
            if symptoms[2]:
            Console.WriteLine("Because of this symptom, you may possibly have the following:" + associatedConditions[3] + "," + associatedConditions[4] + ", and" + associatedConditions[7 + "."])
            if symptoms[3]:
            Console.WriteLine("Because of this symptom, you may have" + associatedConditions[5] + ".")
            Console.WriteLine("With this condition, you should" + treatments[2 + "."])
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")

        }
        public static void retinalDetachment{
            atRisk = ["family history of retinal detachment","previous serious eye injury","past eye surgery","recieved diagnosis of certain eye diseases","are extremely nearsighted","Older than the age of 50"]
            symptoms = ["blurred vision","partial vision loss","sudden flashes of light that appear in one or both eyes","suddenly seeing many floaters"]
            occurances = ["rhegmatogenous","tractional","exudative"]
            treatments = ["Photocoagulation","Cryopexy","Pneumatic retinopexy","Scleral buckling","Vitrectomy","Consult a physician to consult this condition."]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[0]:
            Console.WriteLine(treatments[5])
            if symptoms[1]:
            Console.WriteLine("Because of this continual symptom," + treatments[0] + "is advised.")
            if symptoms[2]:
            Console.WriteLine("Because of this symptom" + treatments[2] + "is advised, so this minor symptom can stop happening.")
            if symptoms[3]:
            Console.WriteLine("Since this is a severe condition, the best reccomendation is" + treatments[5] + ".")
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")
        }
        public static void diabeticRetinopathy{
            atRisk = ["abnormal blood vessels","optic swelling","optic scarring", "optic nerve damage"]
            symptoms = ["seeking floaters or dark spots","difficulty seeing at night","blurred vision","difficulty distinguishing colors","vision loss"]
            occurances = ["High levels of blood sugar","High blood pressure"]
            treatments = ["Injectable medications","Laser treatment","Vitrectomy"]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[0]:
            Console.WriteLine("With this symptom, the best reccomendation is :" + treatments[0] + "which is performed by your doctor.")
            if symptoms[1]:
            Console.WriteLine("Since this is a major sign of vision loss (since there is not enough light coming into your eye), you should get" + treatments[1] + ".")
            if symptoms[2]:
            Console.WriteLine("With this symptom, the best reccomendation is :" + treatments[0] + "which is performed by your doctor.")
            if symptoms[3]:
            Console.WriteLine("For this symptom, the best reccomendation is " + treatments[2] + ".")
            if symptoms[4]:
            Console.WriteLine("Because this can be a varying condition (ranging of intensity), the best reccomendations are either" + treaments[1] "or" + treatments[1] + "."
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")
        }
        public static void epiretinalMembrane{
            symptoms = ["Decreased vision or loss of central vision.","Distorted or blurred vision.","Double vision.","Wavy vision.","Being nearsighted."]
            occurances = ["Often over the age of 50","Posterior vitreous detachment","Retinal tear or detachment","Eye injuries or surgeries","Retinal vascular diseases","Existing eye retinal membrane issue"]
            treatments = ["Vitrectomy","EMR surgery","Consult a physician to consult this condition."]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[0]:
            Console.WriteLine(treatments[2]+ "Then, if necessary get:" + treatments[0] + ".")
            if symptoms[1]:
            Console.WriteLine(treatments[2]+ "Then, based on the doctor's consultation either get :" + treatments[0] + "or" + treatments[1] + ".")
            if symptoms[2]:
            Console.WriteLine(treatments[2])
            if symptoms[3]:
            Console.WriteLine(treatments[2]+ "Then, get :" + treatments[1] + ".")
            if symptoms[4]:
            Console.WriteLine(treatments[2])
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")
        }
        public static void macularHole{
            symptoms = ["Over 60 years old","Very nearsighted","Have had eye surgery or an eye injury"]
            occurances = ["Usually when there's an injury to the eye","A side effect from eye disease causing swelling to the macula"]
            treatments = ["Vitrectomy","Consult a physician to consult this condition."]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[0]:
            Console.WriteLine(treatments[1] + "If the consulation gets diagonosed, then get" + treatments[0] + ".")
            if symptoms[1]:
            Console.WriteLine("Because of this underlying condition, it will be necessary to get" + treatments[0] + ".")
            if symptoms[2]:
            Console.WriteLine(treatments[1] + "If the consulation gets diagonosed, then get" + treatments[0] + ".")
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")
        }
        public static void macularDegeneration{
            Console.WriteLine("There are two forms of macular degeneration including a dry and wet version. Wet macular degeneration progresses more quickly than dry macular degeneration.")
            symptoms = {DryMD: "A reduction in central vision","A distortion of straight lines in your field of vision","The need for brighter lighting","Difficulty adapting to low lights","Blurriness","Trouble recognizing faces","Retinal damage",WetMD: "A blurry spot in your field of vision","A dark spot in the center of your vision due to blood vessels bleeding or leaking fluid","Hazy vision","Rapidly worsening symptoms"}
            occurances = ["Having a family history of macular degeneration","Being over 55 years old","Smoking","Having overweight or obesity","Having cardiovascular disease","Having high cholesterol"]
            dryTreatments = ["Reccomend taking eye vitamins in the AREDS2 formulation.","Get a consultation from a low vision rehabilitation specialist.","Reccomend surgery to improve vision to implant a telescopic lens to replace the natural lens in the eye."]
            wetTreatments = ["Have your doctor inject Anti-vascular endothelial growth factor drugs.","Conduct photodynamic therapy.","Apply photocoagulation therapy, which will require multiple treatments.","Get a consultation from a low vision rehabilitation specialist."]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[DryMD[0]]:
            Console.WriteLine(dryTreatments[0])
            if symptoms[DryMD[1]]:
            Console.WriteLine(dryTreatments[1])
            if symptoms[DryMD[2]]:
            Console.WriteLine(dryTreatments[1])
            if symptoms[DryMD[3]]:
            Console.WriteLine(dryTreatments[0])
            if symptoms[DryMD[4]]:
            Console.WriteLine(dryTreatments[1])
            if symptoms[DryMD[5]]:
            Console.WriteLine(dryTreatments[0])
            if symptoms[DryMD[6]]:
            Console.WriteLine(dryTreatments[2])
            if symptoms[WetMD[0]]:
            Console.WriteLine(wetTreatments[3])
            if symptoms[WetMD[1]]:
            Console.WriteLine(wetTreatments[0])
            if symptoms[WetMD[2]]:
            Console.WriteLine(wetTreatments[3])
            if symptoms[WetMD[3]]:
            Console.WriteLine(wetTreatments[0])
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")
        }
        public static void retinitisPigmentosa{
            symptoms = ["Loss of night vision (beginning in childhood)","Loss of side vision, eventually causing the individual to have central vision."]
            occurances = ["Changes in genes that control retinal cells.","Generally an inherited disorder."]
            treatments = ["Only low vision aids and rehabilitation programs to help individuals reciporate through this condition."]
            for s in symptoms:
            Console.ReadLine(s)
            if symptoms[0]:
            Console.WriteLine(treatments[0])
            if symptoms[1]:
            Console.WriteLine("treatments[0])
            else: Console.WriteLine("You either do not have this condition or your symptoms are not listed.")
        }
    }
}