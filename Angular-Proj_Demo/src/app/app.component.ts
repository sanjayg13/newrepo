import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  Username = '';
  displayDetails = false;
  logCount = 0;
  logs: Date[] = [];

  onResetUsername()
  {
    this.Username = '';
  }

  ToggleDisplay()
  {
    this.logCount++;
    this.displayDetails = !this.displayDetails;
    this.logs.push(new Date());

  }

  // backgroundColor getBackground()
  // {
  //   if(this.logCount > 4)
  //   return this.backgroundColor
  // }

  // getColor()
  // {

  // }
}
