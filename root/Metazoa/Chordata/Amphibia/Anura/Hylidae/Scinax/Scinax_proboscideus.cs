namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax proboscideus
/// NCBI TaxId: 424356
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_proboscideus : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax proboscideus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_proboscideus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 424356;
}
