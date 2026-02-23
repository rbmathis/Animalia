namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Rhyneptesicus;

/// <summary>
/// Species: Rhyneptesicus nasutus
/// NCBI TaxId: 568178
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhyneptesicus_nasutus : Rhyneptesicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhyneptesicus nasutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhyneptesicus_nasutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 568178;
}
