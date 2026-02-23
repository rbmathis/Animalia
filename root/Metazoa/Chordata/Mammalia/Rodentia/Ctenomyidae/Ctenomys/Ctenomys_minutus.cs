namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Ctenomys;

/// <summary>
/// Species: Ctenomys minutus
/// NCBI TaxId: 873083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenomys_minutus : Ctenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenomys minutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenomys_minutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 873083;
}
