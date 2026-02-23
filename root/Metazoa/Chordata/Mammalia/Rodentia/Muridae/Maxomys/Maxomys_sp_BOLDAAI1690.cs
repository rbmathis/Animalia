namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys sp. BOLD:AAI1690
/// NCBI TaxId: 1003853
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_sp_BOLDAAI1690 : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys sp. BOLD:AAI1690";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_sp_BOLDAAI1690";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003853;
}
