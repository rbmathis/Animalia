namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crunomys;

/// <summary>
/// Species: Crunomys sp. Mekongga
/// NCBI TaxId: 3391939
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crunomys_sp_Mekongga : Crunomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crunomys sp. Mekongga";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crunomys_sp_Mekongga";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3391939;
}
