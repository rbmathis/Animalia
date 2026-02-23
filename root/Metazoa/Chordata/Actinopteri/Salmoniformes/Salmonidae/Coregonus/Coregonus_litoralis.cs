namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus litoralis
/// NCBI TaxId: 2881024
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_litoralis : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus litoralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_litoralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2881024;
}
