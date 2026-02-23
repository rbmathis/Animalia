namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Species: Suncus lixus
/// NCBI TaxId: 456971
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Suncus_lixus : Suncus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Suncus lixus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Suncus_lixus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 456971;
}
