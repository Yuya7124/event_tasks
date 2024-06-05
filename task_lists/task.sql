INSERT INTO event_tasks.dbo.task (user_id, task_title, due_date, task_priority)
VALUES (@user_id, @task_title, @due_date, @task_priority);
SELECT CAST(SCOPE_IDENTITY() AS int);