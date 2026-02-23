namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus profundus
/// NCBI TaxId: 2881021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_profundus : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus profundus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_profundus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2881021;
}
