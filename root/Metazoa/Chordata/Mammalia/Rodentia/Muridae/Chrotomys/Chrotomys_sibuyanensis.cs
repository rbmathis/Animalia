namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chrotomys;

/// <summary>
/// Species: Chrotomys sibuyanensis
/// NCBI TaxId: 290249
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chrotomys_sibuyanensis : Chrotomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chrotomys sibuyanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chrotomys_sibuyanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 290249;
}
