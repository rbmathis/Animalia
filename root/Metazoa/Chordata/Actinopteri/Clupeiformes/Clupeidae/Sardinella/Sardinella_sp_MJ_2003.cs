namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinella;

/// <summary>
/// Species: Sardinella sp. MJ-2003
/// NCBI TaxId: 249027
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardinella_sp_MJ_2003 : Sardinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardinella sp. MJ-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardinella_sp_MJ_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 249027;
}
