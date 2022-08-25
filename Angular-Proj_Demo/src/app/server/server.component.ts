import { Component } from '@angular/core';

@Component(
    {
        selector: 'app-server',
        templateUrl:'./server.component.html'
    }
)
export class ServerComponent{
    ServerId: number = 10;
    ServerName : string = "Server1";
    ServerStatus: string = "Offline";

    getServerStatus()
    {
        return this.ServerStatus;
    }
}