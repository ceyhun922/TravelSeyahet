fetch("/Admin/Dashboard/GetMonthlyStats")
  .then(res => res.json())
  .then(data => {

      const labels = data.map(x => x.month);

      const values = data.map(x => x.count);

      console.log(labels);
      console.log(values);

      var optionsProfileVisit = {
        annotations: {
          position: 'back'
        },
        dataLabels: {
          enabled: false
        },
        chart: {
          type: 'bar',
          height: 300
        },
        fill: {
          opacity: 1
        },
        plotOptions: {},
        series: [{
          name: 'Rezervasyon',
          data: values
        }],
        colors: '#435ebe',

        xaxis: {
          categories: labels
        },
      };

      var chartProfileVisit = new ApexCharts(
        document.querySelector("#chart-profile-visit"),
        optionsProfileVisit
      );

      chartProfileVisit.render();
  });

var optionsProfileVisit = {
	annotations: {
		position: 'back'
	},
	dataLabels: {
		enabled:false
	},
	chart: {
		type: 'bar',
		height: 300
	},
	fill: {
		opacity:1
	},
	plotOptions: {
	},
	series: [{
		name: 'sales',
		data: [9,20,30,20,10,20,30,20,10,20]
	}],
	colors: '#435ebe',
	xaxis: {
		categories: ["Jan","Feb","Mar","Apr","May","Jun","Jul", "Aug","Sep","Oct","Nov","Dec"],
	},
}
let optionsVisitorsProfile  = {
	series: [70, 30],
	labels: ['Male', 'Female'],
	colors: ['#435ebe','#55c6e8'],
	chart: {
		type: 'donut',
		width: '100%',
		height:'350px'
	},
	legend: {
		position: 'bottom'
	},
	plotOptions: {
		pie: {
			donut: {
				size: '30%'
			}
		}
	}
}

fetch("/mostmadereservation")
    .then(res => res.json())
    .then(data => {

        console.log(data.tourLocaion); // İçərişəhər tarixi turu
        console.log(data.count);       // 2

        var optionsEurope = {
            series: [{
                name: 'Rezervasyon',
                data: [data.count]   // [2]
            }],
            chart: {
                height: 80,
                type: 'area',
                toolbar: { show: false }
            },
            colors: ['#5350e9'],
            stroke: { width: 2 },
            dataLabels: { enabled: false },
            grid: { show: false },

            xaxis: {
                categories: [data.tourLocaion],  // ["İçərişəhər tarixi turu"]
                labels: { show: true },
                axisTicks: { show: false },
                axisBorder: { show: false }
            },

            yaxis: {
                min: 0,
                max: Math.max(data.count * 2, 10),
                labels: { show: true }
            },

            tooltip: {
                y: {
                    formatter: val => `${val} rezervasyon`
                }
            }
        };

        var chart = new ApexCharts(
            document.querySelector("#chart-europe"),
            optionsEurope
        );

        chart.render();
    });


let optionsAmerica = {
	...optionsEurope,
	colors: ['#008b75'],
}
let optionsIndonesia = {
	...optionsEurope,
	colors: ['#dc3545'],
}



var chartProfileVisit = new ApexCharts(document.querySelector("#chart-profile-visit"), optionsProfileVisit);
var chartVisitorsProfile = new ApexCharts(document.getElementById('chart-visitors-profile'), optionsVisitorsProfile)
var chartEurope = new ApexCharts(document.querySelector("#chart-europe"), optionsEurope);
var chartAmerica = new ApexCharts(document.querySelector("#chart-america"), optionsAmerica);
var chartIndonesia = new ApexCharts(document.querySelector("#chart-indonesia"), optionsIndonesia);

chartIndonesia.render();
chartAmerica.render();
chartEurope.render();
chartProfileVisit.render();
chartVisitorsProfile.render()