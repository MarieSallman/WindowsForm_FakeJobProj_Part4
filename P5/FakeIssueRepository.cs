﻿using System;
using System.Collections.Generic;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        private static List<Issue> _Issues = new List<Issue>();

        public FakeIssueRepository()
        {
            _Issues = new List<Issue>();
            _Issues.Add(new Issue
            {
                Id = 1,
                ProjectId = 1,
                Title = "asdf",
                DiscoveryDate = DateTime.MinValue,
                Discoverer = "dave",
                InitialDescription = "N/A",
                Component = "asdf",
                IssueStatusId = 1
            });

        }
        private string ValidateIssue(Issue issue)
        {
            //The following are placeholders for testing and running purposes
            string a = "";
            return a;
        }
        private bool IsDupliclate(string title)
        {
            //The following is a placeholder for testing and running purposes
            return true;
        }

        public string Add(Issue issue)
        {
            //int Id = issue.Id;
            string newIssueName = issue.Title.Trim();
            if (IsDupliclate(newIssueName))
            {
                return "Issue name already exists";
            }
            if (newIssueName == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            int currentMaxId = 0;
            foreach(Issue l in _Issues)
            {
                currentMaxId = l.Id;
            }
            ++currentMaxId;


            return NO_ERROR;

        }

        public List<Issue> GetAll(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Issue issue)
        {
            throw new System.NotImplementedException();
        }

        public string Modify(Issue issue)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Issue GetIssueById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}