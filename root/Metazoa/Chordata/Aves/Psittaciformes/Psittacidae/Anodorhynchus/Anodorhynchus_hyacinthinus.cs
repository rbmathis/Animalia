namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Anodorhynchus;

/// <summary>
/// Species: Anodorhynchus hyacinthinus
/// NCBI TaxId: 51900
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anodorhynchus_hyacinthinus : Anodorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anodorhynchus hyacinthinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anodorhynchus_hyacinthinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51900;
}
