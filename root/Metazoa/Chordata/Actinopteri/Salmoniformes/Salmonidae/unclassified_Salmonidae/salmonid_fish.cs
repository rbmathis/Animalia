namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.unclassified_Salmonidae;

/// <summary>
/// Species: salmonid fish
/// NCBI TaxId: 36500
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class salmonid_fish : unclassified_Salmonidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "salmonid fish";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "salmonid_fish";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36500;
}
