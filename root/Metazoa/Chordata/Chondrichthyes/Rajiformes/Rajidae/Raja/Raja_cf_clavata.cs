namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Species: Raja cf. clavata
/// NCBI TaxId: 213382
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Raja_cf_clavata : Raja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Raja cf. clavata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Raja_cf_clavata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213382;
}
