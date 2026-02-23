namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis adustus
/// NCBI TaxId: 68723
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: White or cream-colored side stripes, Dark fur with lighter flanks, Bushy tail
/// </summary>
public class Canis_adustus : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis adustus";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Side-striped Jackal";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68723;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "White or cream-colored side stripes",
        "Dark fur with lighter flanks",
        "Bushy tail",
        "Smaller than gray wolves",
        "Pointed ears",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Least Concern";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 12.0;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
