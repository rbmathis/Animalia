namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus kingorum
/// NCBI TaxId: 169845
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_kingorum : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus kingorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_kingorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 169845;
}
