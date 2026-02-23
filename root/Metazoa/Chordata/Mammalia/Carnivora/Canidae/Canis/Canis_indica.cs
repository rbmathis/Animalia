namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis indica
/// NCBI TaxId: 242524
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Reddish-brown or gray coat, Smaller than gray wolves, Slender build
/// </summary>
public class Canis_indica : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis indica";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Canis indica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 242524;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Reddish-brown or gray coat",
        "Smaller than gray wolves",
        "Slender build",
        "Pointed ears",
        "Long legs",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Endangered";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 11.5;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
