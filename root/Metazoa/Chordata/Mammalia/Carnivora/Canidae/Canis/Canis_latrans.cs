namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis latrans
/// NCBI TaxId: 9614
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Grayish-brown fur, Smaller than gray wolves, Pointed ears
/// </summary>
public class Canis_latrans : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis latrans";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "prairie wolf";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9614;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Grayish-brown fur",
        "Smaller than gray wolves",
        "Pointed ears",
        "Bushy tail",
        "Slender build",
        "Highly vocal",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Least Concern";

    /// <summary>Gets the adult length range in centimeters.</summary>
    public (double Min, double Max) AdultLengthCm => (210.0, 315.0);

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 12.0;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
