using CSC_test_ASP.Models;

namespace CSC_test_ASP.Services;

public static class JobService {
    static List<Job> Jobs {get;}
    static int nextId = 1;

    static JobService(){
        Jobs = new List<Job>();
    }

    public static List<Job> GetAll () => Jobs;

    public static Job? GetById (int id) => Jobs.FirstOrDefault(job => job.Id == id);
    
    public static List<Job>? GetByStatus (JobStatus status) => Jobs.FindAll(job => job.Status == status.ToString());

    public static Job CreateNewJob (InputJob job) {
        Job newjob = new Job();
        newjob.Id = nextId++;
        newjob.Name = job.Name;
        newjob.Data = job.Data;
        newjob.Status = JobStatus.pending.ToString();
        Jobs.Add(newjob);
        return newjob;
    }

    public static Job? UpdateJob (int id, InputJob updated_job){
        Job? existingJob = GetById(id);
        if(existingJob != null){ 
            int jobIndex = Jobs.FindIndex(job => job.Id == existingJob.Id);
            Jobs[jobIndex].Name = updated_job.Name;
            Jobs[jobIndex].Data = updated_job.Data;
            return Jobs[jobIndex];
        }

        return null;
    }

    public static void DeleteJob (int jobId){
        Job? existingJob = GetById(jobId);
        if(existingJob != null){
            Jobs.Remove(existingJob);
        }
    }


}