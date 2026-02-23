namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Species: Raja sp. KM-1999
/// NCBI TaxId: 557231
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Raja_sp_KM_1999 : Raja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Raja sp. KM-1999";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Raja_sp_KM_1999";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 557231;
}
