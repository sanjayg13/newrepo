import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent implements OnInit {

  AllowNewServer = false;
  ServerCreationStatus = "No Server is Created!";
  ServerName  = '';
  ServerCreated = false;
  Servers=['Server 1','Server 2','Server 3']


  constructor() { 
    setTimeout(() => {
      this.AllowNewServer = true;
    }, 2000);
  }

  ngOnInit(): void {
  }

  onAddNewServer()
  {
    this.Servers.push(this.ServerName);
    this.ServerCreationStatus = "New Server is Added with name " + this.ServerName;
    this.ServerCreated = true;
  }

  onUpdateServer(event:Event)
  {
    this.ServerName = (<HTMLInputElement>event.target).value;
  }

}
