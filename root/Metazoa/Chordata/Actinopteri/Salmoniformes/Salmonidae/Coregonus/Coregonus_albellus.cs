namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus albellus
/// NCBI TaxId: 861747
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_albellus : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus albellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_albellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 861747;
}
