namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samariscus;

/// <summary>
/// Species: Samariscus japonicus
/// NCBI TaxId: 1286132
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Samariscus_japonicus : Samariscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Samariscus japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Samariscus_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1286132;
}
