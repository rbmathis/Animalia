namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis mesomelas
/// NCBI TaxId: 68725
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Black-backed coloring with rusty-red flanks, Small size, Pointed ears
/// </summary>
public class Canis_mesomelas : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis mesomelas";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Silver-backed Jackal";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68725;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Black-backed coloring with rusty-red flanks",
        "Small size",
        "Pointed ears",
        "Bushy tail",
        "Slender build",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Least Concern";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 11.5;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
