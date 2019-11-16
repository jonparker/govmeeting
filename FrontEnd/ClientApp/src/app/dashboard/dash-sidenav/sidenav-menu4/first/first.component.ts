import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.scss']
})
// export class FirstComponent implements OnInit {

//   constructor() { }

//   ngOnInit() {
//   }

// }

export class FirstComponent implements OnInit, OnDestroy {
  id: string;
  location: string;
  private sub: any;

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
       this.id = params['id']; // (+) converts string 'id' to a number
      //  this.location = params['location'];
       console.log("id = " + this.id)
      //  console.log("location = " + this.location)

       // In a real app: dispatch action to load the details here.
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
