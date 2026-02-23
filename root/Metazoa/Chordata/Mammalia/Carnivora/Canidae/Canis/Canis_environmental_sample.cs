namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis environmental
/// NCBI TaxId: 1002244
/// Enrichment Status: Enriched (2026-02-23)
/// </summary>
public class Canis_environmental_sample : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis environmental";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Canis environmental";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002244;

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Unknown";

}
