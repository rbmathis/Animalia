namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Gavialidae.Gavialis;

/// <summary>
/// Species: Gavialis gangeticus
/// NCBI TaxId: 94835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gavialis_gangeticus : Gavialis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gavialis gangeticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gavialis_gangeticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94835;
}
