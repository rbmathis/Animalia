namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis lupus
/// NCBI TaxId: 9612
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Large robust build, Gray fur with brown and black markings, Thick double coat
/// </summary>
public class Canis_lupus : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis lupus";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "timber wolf";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9612;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Large robust build",
        "Gray fur with brown and black markings",
        "Thick double coat",
        "Powerful jaws",
        "Intelligent and social",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Least Concern";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 11.5;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
