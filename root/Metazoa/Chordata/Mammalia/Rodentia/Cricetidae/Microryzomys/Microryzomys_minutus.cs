namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microryzomys;

/// <summary>
/// Species: Microryzomys minutus
/// NCBI TaxId: 37025
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microryzomys_minutus : Microryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microryzomys minutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microryzomys_minutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37025;
}
