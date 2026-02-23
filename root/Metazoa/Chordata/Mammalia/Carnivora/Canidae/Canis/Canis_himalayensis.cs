namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis himalayensis
/// NCBI TaxId: 242525
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Smaller than gray wolves, Pale grayish fur, Lean muscular build
/// </summary>
public class Canis_himalayensis : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis himalayensis";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Canis himalayensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 242525;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Smaller than gray wolves",
        "Pale grayish fur",
        "Lean muscular build",
        "High-altitude adapted",
        "Pointed ears",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Endangered";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 13.0;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
