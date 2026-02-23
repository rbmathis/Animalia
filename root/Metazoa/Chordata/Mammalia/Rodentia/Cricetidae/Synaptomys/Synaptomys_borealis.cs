namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Synaptomys;

/// <summary>
/// Species: Synaptomys borealis
/// NCBI TaxId: 98318
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Synaptomys_borealis : Synaptomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Synaptomys borealis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Synaptomys_borealis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98318;
}
