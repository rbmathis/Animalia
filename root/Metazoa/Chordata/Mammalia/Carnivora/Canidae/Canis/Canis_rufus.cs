namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis rufus
/// NCBI TaxId: 45781
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Reddish-rusty fur, Medium-sized canid, Larger than coyotes but smaller than gray wolves
/// </summary>
public class Canis_rufus : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis rufus";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Red Wolf";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45781;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Reddish-rusty fur",
        "Medium-sized canid",
        "Larger than coyotes but smaller than gray wolves",
        "Pointed ears",
        "Bushy tail",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Critically Endangered";

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 13.0;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
