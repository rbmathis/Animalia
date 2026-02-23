namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.unclassified_Vespertilionidae;

/// <summary>
/// Species: Vespertilionidae sp.
/// NCBI TaxId: 3117228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vespertilionidae_sp : unclassified_Vespertilionidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vespertilionidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vespertilionidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3117228;
}
