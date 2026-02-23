namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

/// <summary>
/// Species: Aethomys ineptus
/// NCBI TaxId: 284517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aethomys_ineptus : Aethomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aethomys ineptus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aethomys_ineptus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 284517;
}
