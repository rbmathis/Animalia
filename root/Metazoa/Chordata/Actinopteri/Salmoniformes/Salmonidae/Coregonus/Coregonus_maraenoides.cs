namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus maraenoides
/// NCBI TaxId: 2908918
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_maraenoides : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus maraenoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_maraenoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2908918;
}
