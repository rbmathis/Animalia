namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus ornatus
/// NCBI TaxId: 2756181
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_ornatus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus ornatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_ornatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2756181;
}
