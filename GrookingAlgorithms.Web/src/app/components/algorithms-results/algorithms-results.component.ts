import { Component, OnInit } from '@angular/core';
import { AlgorithmResultsService } from 'src/app/services/algorithm-results/algorithm-results.service';

@Component({
  selector: 'app-algorithms-results',
  templateUrl: './algorithms-results.component.html',
  styleUrls: ['./algorithms-results.component.css']
})
export class AlgorithmsResultsComponent implements OnInit {

  dataSource = [];
  displayedColumns: string[] = ['executionTime', 'complexity', 'searchedValue'];

  constructor(private algorithmResultsService:AlgorithmResultsService) { }

  ngOnInit() {
    this.algorithmResultsService.get().subscribe(x=>{
      this.dataSource = x;
      console.log("response = ", x);
    });
  }
}


