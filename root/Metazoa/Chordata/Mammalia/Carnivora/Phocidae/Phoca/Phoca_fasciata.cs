namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Phoca;

/// <summary>
/// Species: Phoca fasciata
/// NCBI TaxId: 39088
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phoca_fasciata : Phoca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phoca fasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phoca_fasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39088;
}
