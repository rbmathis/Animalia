namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus acanthurus
/// NCBI TaxId: 62035
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_acanthurus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus acanthurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_acanthurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62035;
}
