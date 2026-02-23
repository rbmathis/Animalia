namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eptesicus;

/// <summary>
/// Species: Eptesicus sp.
/// NCBI TaxId: 3042450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eptesicus_sp : Eptesicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eptesicus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eptesicus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3042450;
}
