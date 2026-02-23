namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Kanakysaurus;

/// <summary>
/// Species: Kanakysaurus zebratus
/// NCBI TaxId: 2051858
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kanakysaurus_zebratus : Kanakysaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kanakysaurus zebratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kanakysaurus_zebratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2051858;
}
