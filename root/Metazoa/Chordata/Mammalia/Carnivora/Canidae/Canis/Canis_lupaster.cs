namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis lupaster
/// NCBI TaxId: 1707807
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Golden-tan or grayish-tan fur, Slender build, Smaller than gray wolves
/// </summary>
public class Canis_lupaster : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis lupaster";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Canis lupaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1707807;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Golden-tan or grayish-tan fur",
        "Slender build",
        "Smaller than gray wolves",
        "Pointed ears",
        "Bushy tail",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Least Concern";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 11.0;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
