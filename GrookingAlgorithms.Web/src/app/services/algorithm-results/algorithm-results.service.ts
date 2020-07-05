import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AlgorithmResult } from 'src/app/models/algorithm-result';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AlgorithmResultsService {

  private url = environment.apiUrl + '/api/AlgorithmResults'; 

  constructor(private http: HttpClient) { }

  get(): Observable<AlgorithmResult[]> {
    return this.http.get<AlgorithmResult[]>(this.url)
  }
}
