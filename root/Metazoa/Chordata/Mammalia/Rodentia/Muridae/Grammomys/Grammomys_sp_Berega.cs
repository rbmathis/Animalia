namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

/// <summary>
/// Species: Grammomys sp. Berega
/// NCBI TaxId: 122201
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grammomys_sp_Berega : Grammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grammomys sp. Berega";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grammomys_sp_Berega";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 122201;
}
