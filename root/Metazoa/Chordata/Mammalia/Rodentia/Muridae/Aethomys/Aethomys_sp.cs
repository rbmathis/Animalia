namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

/// <summary>
/// Species: Aethomys sp.
/// NCBI TaxId: 61152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aethomys_sp : Aethomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aethomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aethomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61152;
}
