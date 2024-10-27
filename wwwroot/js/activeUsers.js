const connection = new signalR.HubConnectionBuilder().withUrl("/hubs/UsersCount").build();

connection.on("TotalActiveUsers", (TotalActiveUsers) => {
    document.getElementById("active-users").innerText = `Players online - ${TotalActiveUsers}`
});

connection.start().then(() => { console.log("Connection started !!") }, () => { "Connection Rejected"});