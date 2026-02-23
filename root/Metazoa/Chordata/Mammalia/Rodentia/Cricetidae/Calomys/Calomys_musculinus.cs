namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys musculinus
/// NCBI TaxId: 56212
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_musculinus : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys musculinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_musculinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56212;
}
