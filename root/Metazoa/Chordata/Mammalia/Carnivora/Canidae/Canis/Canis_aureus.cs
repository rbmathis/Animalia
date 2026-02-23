namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis aureus
/// NCBI TaxId: 68724
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Golden-tan colored fur, Smaller than gray wolves, Slender build
/// </summary>
public class Canis_aureus : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis aureus";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Golden Jackal";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68724;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Golden-tan colored fur",
        "Smaller than gray wolves",
        "Slender build",
        "Pointed ears",
        "Bushy tail",
        "Long legs",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Least Concern";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 11.5;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
