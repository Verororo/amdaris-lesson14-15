using ConsoleApp1.Services;

Staff andrew = new Staff { Name = "Andrew", Email = "andrew@srl.com "};
StaffService.freeStaff.Add(andrew);

Customer john = new Customer { Name = "John", Email = "john@example.com" };
Order chair = john.CreateOrder("Chair");

andrew.OrderApprove(chair);