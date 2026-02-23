namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.unclassified_Scincidae;

/// <summary>
/// Species: Scincidae sp.
/// NCBI TaxId: 2590758
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scincidae_sp : unclassified_Scincidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scincidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scincidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2590758;
}
