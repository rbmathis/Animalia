namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus dumerilii
/// NCBI TaxId: 169837
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_dumerilii : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus dumerilii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_dumerilii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 169837;
}
