namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Cyclanorbis;

/// <summary>
/// Species: Cyclanorbis elegans
/// NCBI TaxId: 227469
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclanorbis_elegans : Cyclanorbis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclanorbis elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclanorbis_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227469;
}
