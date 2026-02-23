namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo sp. CCMAR 152
/// NCBI TaxId: 2979014
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_sp_CCMAR_152 : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo sp. CCMAR 152";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_sp_CCMAR_152";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2979014;
}
