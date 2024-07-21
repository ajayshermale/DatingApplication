import { NgFor } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component,inject,OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,NgFor],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
 
  http = inject(HttpClient) ;
  title = "User Details :" ;
  users: any;


  ngOnInit(): void {
    this.http.get("http://localhost:5289/Api/user").subscribe({
   next: Response => this.users =Response,
   error: error => console.log(error),
   complete:() => console.log('Response Completed Successfully!') 

    });
  }
}
