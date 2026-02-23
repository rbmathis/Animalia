namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

/// <summary>
/// Species: Grammomys sp. PC-2007
/// NCBI TaxId: 485424
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grammomys_sp_PC_2007 : Grammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grammomys sp. PC-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grammomys_sp_PC_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 485424;
}
