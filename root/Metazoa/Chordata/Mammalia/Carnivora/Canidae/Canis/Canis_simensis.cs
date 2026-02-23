namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis simensis
/// NCBI TaxId: 32534
/// Enrichment Status: Enriched (2026-02-23)
/// Distinctive features: Reddish coat with white patches, Slender build, Long thin legs
/// </summary>
public class Canis_simensis : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis simensis";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Simien Jackal";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 32534;

    /// <summary>Gets distinctive characteristics of this species.</summary>
    public string[] SpeciesCharacteristics => new[]
    {
        "Reddish coat with white patches",
        "Slender build",
        "Long thin legs",
        "Pointed ears",
        "Small canid",
    };

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Endangered status";

    /// <summary>Gets the adult length range in centimeters.</summary>
    public (double Min, double Max) AdultLengthCm => (11.2, 16.8);

    /// <summary>Gets the average lifespan in years.</summary>
    public double AverageLifespanYears => 11.0;

    /// <summary>Gets the reproduction method.</summary>
    public string ReproductionMethod => "Viviparous";

}
