using CSC_test_ASP.Models;
using CSC_test_ASP.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSC_test_ASP.Controllers;

[ApiController]
[Route("[controller]")]
public class JobsController: ControllerBase {
    public JobsController(){}

    [HttpGet]
    public ActionResult<List<Job>> GetAll () => JobService.GetAll();

    [HttpGet("{status}")]
    public ActionResult<List<Job>> GetByStatus (JobStatus status){
        List<Job>? jobs = JobService.GetByStatus(status);
        if(jobs is null){
            return NotFound();
        }

        return jobs;
    }

    [HttpPost]
    public ActionResult<Job> CreateNewJob (InputJob job){
        Job createdJob = JobService.CreateNewJob(job);
        return createdJob;
    }

    [HttpPut("{id}")]
    public ActionResult<Job> UpdateJob (int id, InputJob job){
        Job? updatedJob = JobService.UpdateJob(id, job);

        if(updatedJob == null){
            return NotFound();
        }

        return updatedJob;
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteJob(int id){
        Job? existingJob = JobService.GetById(id);

        if(existingJob == null){
            return NotFound();
        }

        JobService.DeleteJob(id);
        return Ok();
    }
}