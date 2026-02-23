namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tarsomys;

/// <summary>
/// Species: Tarsomys sp. FMNH 194803
/// NCBI TaxId: 3002831
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tarsomys_sp_FMNH_194803 : Tarsomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tarsomys sp. FMNH 194803";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tarsomys_sp_FMNH_194803";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3002831;
}
