namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Species: Raja parva
/// NCBI TaxId: 2979237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Raja_parva : Raja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Raja parva";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Raja_parva";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2979237;
}
