namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus salvadorii
/// NCBI TaxId: 62049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_salvadorii : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus salvadorii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_salvadorii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62049;
}
