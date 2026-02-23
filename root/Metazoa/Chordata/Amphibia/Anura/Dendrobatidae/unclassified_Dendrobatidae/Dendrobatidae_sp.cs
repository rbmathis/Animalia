namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.unclassified_Dendrobatidae;

/// <summary>
/// Species: Dendrobatidae sp.
/// NCBI TaxId: 3117551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendrobatidae_sp : unclassified_Dendrobatidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendrobatidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendrobatidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3117551;
}
