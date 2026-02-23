namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eptesicus;

/// <summary>
/// Species: Eptesicus dutertreus
/// NCBI TaxId: 3369970
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eptesicus_dutertreus : Eptesicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eptesicus dutertreus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eptesicus_dutertreus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3369970;
}
