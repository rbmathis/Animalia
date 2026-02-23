namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Species: Raja cf. asterias
/// NCBI TaxId: 213383
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Raja_cf_asterias : Raja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Raja cf. asterias";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Raja_cf_asterias";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213383;
}
