namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

/// <summary>
/// Species: Sus sp. PCIMan002
/// NCBI TaxId: 432590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sus_sp_PCIMan002 : Sus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sus sp. PCIMan002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sus_sp_PCIMan002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 432590;
}
