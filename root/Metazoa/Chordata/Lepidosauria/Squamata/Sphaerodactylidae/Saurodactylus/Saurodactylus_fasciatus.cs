namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Saurodactylus;

/// <summary>
/// Species: Saurodactylus fasciatus
/// NCBI TaxId: 456484
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saurodactylus_fasciatus : Saurodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saurodactylus fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saurodactylus_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 456484;
}
