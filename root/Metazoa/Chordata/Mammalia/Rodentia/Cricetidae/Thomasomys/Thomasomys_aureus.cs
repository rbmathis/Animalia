namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys;

/// <summary>
/// Species: Thomasomys aureus
/// NCBI TaxId: 29131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomasomys_aureus : Thomasomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomasomys aureus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomasomys_aureus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29131;
}
