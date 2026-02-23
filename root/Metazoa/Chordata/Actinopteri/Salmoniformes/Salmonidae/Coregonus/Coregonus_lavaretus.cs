namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus lavaretus
/// NCBI TaxId: 59291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_lavaretus : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus lavaretus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_lavaretus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59291;
}
