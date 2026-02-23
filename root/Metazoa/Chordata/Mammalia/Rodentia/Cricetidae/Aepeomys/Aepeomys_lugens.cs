namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Aepeomys;

/// <summary>
/// Species: Aepeomys lugens
/// NCBI TaxId: 329888
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aepeomys_lugens : Aepeomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aepeomys lugens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aepeomys_lugens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329888;
}
