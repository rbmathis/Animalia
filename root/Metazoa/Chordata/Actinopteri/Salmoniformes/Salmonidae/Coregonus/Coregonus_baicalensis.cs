namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus baicalensis
/// NCBI TaxId: 86068
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_baicalensis : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus baicalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_baicalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 86068;
}
