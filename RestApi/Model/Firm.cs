using System;
using Microsoft.Azure.Documents.Spatial;

namespace Shopper.Core.Model
{
    public class Firm
    {
        public Guid Id { get; set; }
        public Point LatLong { get; set; }
    }
}