import React, { Component } from 'react';

export class FetchWeather extends Component {
    static displayName = FetchWeather.name;

  constructor (props) {
    super(props);
      this.state = {
          forecasts: [], loading: true, location: {Latitude: 0, Longitude: 0}
      };


  }

    changeLocation = (event) => {
        const name = event.target.name;
        const value = event.target.value;
        const { location } = this.state;
        const newLocation = {
            ...location,
            [name]: value
        };
        this.setState({ location: newLocation });

        let latitude = this.state.location.Latitude !== '' ? this.state.location.Latitude : '0';
        let longitude = this.state.location.Longitude !== '' ? this.state.location.Longitude : '0';



        fetch('api/Weather/Get?lat=' + latitude  + '&lng=' + longitude)
            .then(response => response.json())
            .then(data => {
                this.setState({ forecasts: data, loading: false });
            });
    }

    static renderForecastsTable(forecasts) {

        console.log(forecasts);
        return (
          <table className='table table-striped'>
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

    render() {
        let contents = this.state.loading
            ? <p><em>Enter coordinates...</em></p>
            : FetchWeather.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <div className="col-md-6">
                    <h1>Weather Forecast (7-day)</h1>
                </div>
                <form className="form-inline mb-3">
                    <div className="col-md-12 form-group">
                        <input type="number" className="form-control" name="Latitude" placeholder="Latitude" onChange={this.changeLocation} />
                        <input type="number" className="form-control" name="Longitude" placeholder="Longtitude" onChange={this.changeLocation} />
                    </div>
                </form>
            {contents}
          </div>
        );
    }
}
