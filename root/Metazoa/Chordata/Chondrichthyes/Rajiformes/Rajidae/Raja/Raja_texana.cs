namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Species: Raja texana
/// NCBI TaxId: 1419742
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Raja_texana : Raja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Raja texana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Raja_texana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1419742;
}
