namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hylophorbus;

/// <summary>
/// Species: Hylophorbus atrifasciatus
/// NCBI TaxId: 2864261
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylophorbus_atrifasciatus : Hylophorbus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylophorbus atrifasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylophorbus_atrifasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2864261;
}
