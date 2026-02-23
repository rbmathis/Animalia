namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys sp. ADM-2011
/// NCBI TaxId: 1116257
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_sp_ADM_2011 : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys sp. ADM-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_sp_ADM_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1116257;
}
