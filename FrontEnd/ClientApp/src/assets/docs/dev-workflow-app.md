
The  project "WorkflowApp" in folder "BackEnd/WorkflowApp" does all the auto-processing of recordings and transcripts.
It also co-ordinates manual processing with auto-processing.
When you run this project, it will watch for new files to arrive into the folder "Datafiles/TO_PROCESS". If it is a video file,
it will process the file an produce a transcript". The transcript can be found in the "Datafiles/WORK" folder in a subfolder named after
the government agency whose meeting it is for. This transcript must still be further processed as described in
<a [routerLink]="['/manualprocessing']">Manual Processing</a>

If the file is a text file (.pdf or .txt), Workflow will process the transcript and
produce a file containing a JSON object that has the contents of the transcript in a structured format.
Seperate fields within this JSON object will contain spoken text, the name of the speaker, setion name, etc.

While it is processing the text file, the Workflow process will output trace files to the Datafiles/WORK folder.
Each trace file contains the complete text of the transcript, after each particular fix is applied.
Therefore if the final fixed transcript contains strange or invalid text, it is easy to trace it
back to where those errors were introduced during the "fix" process.

## Improve speech Recognition


The more accurate the speech recognition, the less manual proofreading must be done.
The software use the Google Speech API. Multi-speaker conversational speech is challanging.
But the accuracy of the engine keeps improving.

There are ways that we can improve the accuracy.

* We do not need to transcribe in real time. We can pre-process the audo to clirify it, remove extraneous sounds, etc.

*  There are a number of techniques that Google provides to increase accuracy:
  speech adaptation, custom dictionaries, phrase collections, etc.
