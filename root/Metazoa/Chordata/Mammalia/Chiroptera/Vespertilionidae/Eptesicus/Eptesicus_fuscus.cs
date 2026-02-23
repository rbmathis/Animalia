namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eptesicus;

/// <summary>
/// Species: Eptesicus fuscus
/// NCBI TaxId: 29078
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eptesicus_fuscus : Eptesicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eptesicus fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eptesicus_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29078;
}
