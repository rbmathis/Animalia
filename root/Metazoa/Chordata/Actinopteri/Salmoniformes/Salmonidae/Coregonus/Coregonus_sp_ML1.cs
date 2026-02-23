namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus sp. ML1
/// NCBI TaxId: 861782
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_sp_ML1 : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus sp. ML1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_sp_ML1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 861782;
}
