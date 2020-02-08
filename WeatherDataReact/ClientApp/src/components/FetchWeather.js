import React, { Component } from 'react';

export class FetchWeather extends Component {
    static displayName = FetchWeather.name;

  constructor (props) {
    super(props);
    this.state = { forecasts: [], loading: true };

    fetch('api/Weather/Get')
      .then(response => response.json())
      .then(data => {
        this.setState({ forecasts: data, loading: false });
      });
  }

  static renderForecastsTable (forecasts) {
    return (
      <table className='table table-striped table-dark'>
        <thead>
          <tr>
            <th>Date</th>
            <th className="text-danger">Temp. High (F)</th>
            <th className="text-info">Temp. Low (F)</th>
            <th className="text-danger">Temp. High (C)</th>
            <th className="text-info">Temp. Low (C)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.dateFormatted}>
                <td>{forecast.dateFormatted}</td>
                  <td>{forecast.temperatureHighF}&#8457;</td>
                  <td>{forecast.temperatureLowF}&#8457;</td>
                  <td>{forecast.temperatureHighC}&#8451;</td>
                  <td>{forecast.temperatureLowC}&#8451;</td>
                <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : FetchWeather.renderForecastsTable(this.state.forecasts);

    return (
        <div>
            <div className="col-md-6">
                <h1>Weather Forecast (7-day)</h1>
            </div>
            <form className="form-inline mb-3">
                <div className="col-md-12 form-group">
                    <input type="number" className="form-control" id="txtLatitude" placeholder="Latitude" />
                    <input type="number" className="form-control" id="txtLongitude" placeholder="Longitude" />
                    <button type="submit" class="btn btn-primary" onClick="ChangeLocation()">Confirm Location</button>
                </div>
            </form>
        {contents}
      </div>
    );
  }
}
