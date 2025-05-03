using System.Collections.Generic;

namespace ProductList.Models
    {
    public static class SimpleListRepository
        {
        public static readonly List<SimpleSupplier> SimpleSuppliers = new List<SimpleSupplier>
        {
            new SimpleSupplier{ SimpleSupplierID = 1, SimpleSuppierName = "Develop Manufacturing Ltd" },
            new SimpleSupplier{ SimpleSupplierID = 2, SimpleSuppierName = "Venture Thingies"},
            new SimpleSupplier{ SimpleSupplierID = 3, SimpleSuppierName = "Major Manufacturing"},
            new SimpleSupplier{ SimpleSupplierID = 4, SimpleSuppierName = "Mystery Product Co"},
            new SimpleSupplier{ SimpleSupplierID = 5, SimpleSuppierName = "Basement Company"},
            new SimpleSupplier{ SimpleSupplierID = 6, SimpleSuppierName = "Conficio Co"},
            new SimpleSupplier{ SimpleSupplierID = 7, SimpleSuppierName = "Fabrico Manufacturings"},
            new SimpleSupplier{ SimpleSupplierID = 8, SimpleSuppierName = "WeMake IT YouBreak IT" },
            new SimpleSupplier{ SimpleSupplierID = 9, SimpleSuppierName = "Lambent Illumination"}
        };

        public static readonly List<SimpleProduct> SimpleProducts = new List<SimpleProduct>
        {
            new SimpleProduct{ SimpleProductID = 1, SimpleProductName = "Plumbus", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 1, SimpleSupplierID = 6, SimplePrice = 42.37},
                new SimpleProductSupplier{ SimpleProductID = 1, SimpleSupplierID = 9, SimplePrice = 32.34},
                new SimpleProductSupplier{ SimpleProductID = 1, SimpleSupplierID = 7, SimplePrice = 55.61}
                }
                },

            new SimpleProduct{ SimpleProductID = 2, SimpleProductName = "Orbital Keys", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 2, SimpleSupplierID = 8, SimplePrice = 74.17},
                new SimpleProductSupplier{ SimpleProductID = 2, SimpleSupplierID = 4, SimplePrice = 86.77},
                new SimpleProductSupplier{ SimpleProductID = 2, SimpleSupplierID = 6, SimplePrice = 63.65}
                }
                },

            new SimpleProduct{ SimpleProductID = 3, SimpleProductName = "XPress Bottle", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 3, SimpleSupplierID = 9, SimplePrice = 83.52},
                new SimpleProductSupplier{ SimpleProductID = 3, SimpleSupplierID = 6, SimplePrice = 91.20},
                new SimpleProductSupplier{ SimpleProductID = 3, SimpleSupplierID = 8, SimplePrice = 73.89}
                }
                },

            new SimpleProduct{ SimpleProductID = 4, SimpleProductName = "InstaPress", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 4, SimpleSupplierID = 2, SimplePrice = 93.99},
                new SimpleProductSupplier{ SimpleProductID = 4, SimpleSupplierID = 8, SimplePrice = 88.28},
                new SimpleProductSupplier{ SimpleProductID = 4, SimpleSupplierID = 5, SimplePrice = 71.68}
                }
                },

            new SimpleProduct{ SimpleProductID = 5, SimpleProductName = "Uno Wear", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 5, SimpleSupplierID = 6, SimplePrice = 55.00},
                new SimpleProductSupplier{ SimpleProductID = 5, SimpleSupplierID = 1, SimplePrice = 99.00},
                new SimpleProductSupplier{ SimpleProductID = 5, SimpleSupplierID = 2, SimplePrice = 91.30}
                }
                },

            new SimpleProduct{ SimpleProductID = 6, SimpleProductName = "Swish Wallet", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 6, SimpleSupplierID = 6, SimplePrice = 71.04},
                new SimpleProductSupplier{ SimpleProductID = 6, SimpleSupplierID = 9, SimplePrice = 83.12},
                new SimpleProductSupplier{ SimpleProductID = 6, SimpleSupplierID = 3, SimplePrice = 84.17}
                }
                },

            new SimpleProduct{ SimpleProductID = 7, SimpleProductName = "Onovo Supply", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 7, SimpleSupplierID = 7, SimplePrice = 51.86},
                new SimpleProductSupplier{ SimpleProductID = 7, SimpleSupplierID = 8, SimplePrice = 69.07},
                new SimpleProductSupplier{ SimpleProductID = 7, SimpleSupplierID = 4, SimplePrice = 60.22}
                }
                },

            new SimpleProduct{ SimpleProductID = 8, SimpleProductName = "Sharpy Knife", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 8, SimpleSupplierID = 4, SimplePrice = 63.54},
                new SimpleProductSupplier{ SimpleProductID = 8, SimpleSupplierID = 8, SimplePrice = 55.02},
                new SimpleProductSupplier{ SimpleProductID = 8, SimpleSupplierID = 1, SimplePrice = 44.85}
                }
                },

            new SimpleProduct{ SimpleProductID = 9, SimpleProductName = "Towlee", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 9, SimpleSupplierID = 7, SimplePrice = 44.96},
                new SimpleProductSupplier{ SimpleProductID = 9, SimpleSupplierID = 6, SimplePrice = 31.81},
                new SimpleProductSupplier{ SimpleProductID = 9, SimpleSupplierID = 8, SimplePrice = 57.83}
                }
                },

            new SimpleProduct{ SimpleProductID = 10, SimpleProductName = "Rhino Case", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 10, SimpleSupplierID = 7, SimplePrice = 24.24},
                new SimpleProductSupplier{ SimpleProductID = 10, SimpleSupplierID = 1, SimplePrice = 28.45},
                new SimpleProductSupplier{ SimpleProductID = 10, SimpleSupplierID = 2, SimplePrice = 27.24}
                }
                },

            new SimpleProduct{ SimpleProductID = 11, SimpleProductName = "Mono", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 11, SimpleSupplierID = 3, SimplePrice = 69.99},
                new SimpleProductSupplier{ SimpleProductID = 11, SimpleSupplierID = 7, SimplePrice = 82.51},
                new SimpleProductSupplier{ SimpleProductID = 11, SimpleSupplierID = 9, SimplePrice = 90.60}
                }
                },

            new SimpleProduct{ SimpleProductID = 12, SimpleProductName = "Vortex Bottle",   SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 12, SimpleSupplierID = 2, SimplePrice = 42.47},
                new SimpleProductSupplier{ SimpleProductID = 12, SimpleSupplierID = 1, SimplePrice = 46.88},
                new SimpleProductSupplier{ SimpleProductID = 12, SimpleSupplierID = 4, SimplePrice = 61.24}
                }
                },

            new SimpleProduct{ SimpleProductID = 13, SimpleProductName = "Handy Mop", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 13, SimpleSupplierID = 3, SimplePrice = 17.78},
                new SimpleProductSupplier{ SimpleProductID = 13, SimpleSupplierID = 8, SimplePrice = 89.68},
                new SimpleProductSupplier{ SimpleProductID = 13, SimpleSupplierID = 9, SimplePrice = 76.21}
                }
                },

            new SimpleProduct{ SimpleProductID = 14, SimpleProductName = "Terra Shsave", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 14, SimpleSupplierID = 8, SimplePrice = 90.759},
                new SimpleProductSupplier{ SimpleProductID = 14, SimpleSupplierID = 6, SimplePrice = 63.43},
                new SimpleProductSupplier{ SimpleProductID = 14, SimpleSupplierID = 5, SimplePrice = 73.30}
                }
                },

            new SimpleProduct{ SimpleProductID = 15, SimpleProductName = "Stickem", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 15, SimpleSupplierID = 3, SimplePrice = 74.82},
                new SimpleProductSupplier{ SimpleProductID = 15, SimpleSupplierID = 6, SimplePrice = 63.36},
                new SimpleProductSupplier{ SimpleProductID = 15, SimpleSupplierID = 7, SimplePrice = 50.58}
                }
                },

            new SimpleProduct{ SimpleProductID = 16, SimpleProductName = "Scruncho", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 16, SimpleSupplierID = 2, SimplePrice = 58.61},
                new SimpleProductSupplier{ SimpleProductID = 16, SimpleSupplierID = 5, SimplePrice = 73.29},
                new SimpleProductSupplier{ SimpleProductID = 16, SimpleSupplierID = 1, SimplePrice = 45.57}
                }
                },

            new SimpleProduct{ SimpleProductID = 17, SimpleProductName = "Gymr Kit", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 17, SimpleSupplierID = 1, SimplePrice = 83.09},
                new SimpleProductSupplier{ SimpleProductID = 17, SimpleSupplierID = 5, SimplePrice = 77.98},
                new SimpleProductSupplier{ SimpleProductID = 17, SimpleSupplierID = 4, SimplePrice = 69.16}
                }
                },

            new SimpleProduct{ SimpleProductID = 18, SimpleProductName = "Crash-y-Crash",  SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 18, SimpleSupplierID = 4, SimplePrice = 22.03},
                new SimpleProductSupplier{ SimpleProductID = 18, SimpleSupplierID = 1, SimplePrice = 17.46},
                new SimpleProductSupplier{ SimpleProductID = 18, SimpleSupplierID = 8, SimplePrice = 18.89}
                }
                },

            new SimpleProduct{ SimpleProductID = 19, SimpleProductName = "Peek-aboo", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 19, SimpleSupplierID = 3, SimplePrice = 98.07},
                new SimpleProductSupplier{ SimpleProductID = 19, SimpleSupplierID = 1, SimplePrice = 98.45},
                new SimpleProductSupplier{ SimpleProductID = 19, SimpleSupplierID = 7, SimplePrice = 91.68}
                }
                },

            new SimpleProduct{ SimpleProductID = 20, SimpleProductName = "Empty Space", SimplePrices = new List<SimpleProductSupplier> {
                new SimpleProductSupplier{ SimpleProductID = 20, SimpleSupplierID = 5, SimplePrice = 27.94},
                new SimpleProductSupplier{ SimpleProductID = 20, SimpleSupplierID = 3, SimplePrice = 23.40},
                new SimpleProductSupplier{ SimpleProductID = 20, SimpleSupplierID = 9, SimplePrice = 30.24}
                }
                },
            };
        }
    }