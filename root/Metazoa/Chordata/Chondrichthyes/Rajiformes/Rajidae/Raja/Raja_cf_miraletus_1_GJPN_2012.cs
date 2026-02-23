namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Species: Raja cf. miraletus 1 GJPN-2012
/// NCBI TaxId: 1214733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Raja_cf_miraletus_1_GJPN_2012 : Raja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Raja cf. miraletus 1 GJPN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Raja_cf_miraletus_1_GJPN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1214733;
}
