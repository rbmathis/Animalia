namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys;

/// <summary>
/// Species: Phyllomys blainvillii
/// NCBI TaxId: 466159
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllomys_blainvillii : Phyllomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllomys blainvillii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllomys_blainvillii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 466159;
}
