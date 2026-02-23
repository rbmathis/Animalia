namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus sp. MFG-2013
/// NCBI TaxId: 1291124
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_sp_MFG_2013 : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus sp. MFG-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_sp_MFG_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1291124;
}
