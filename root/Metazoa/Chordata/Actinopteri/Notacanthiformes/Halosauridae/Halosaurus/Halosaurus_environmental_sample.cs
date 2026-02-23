namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Halosauridae.Halosaurus;

/// <summary>
/// Species: Halosaurus environmental sample
/// NCBI TaxId: 1366075
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Halosaurus_environmental_sample : Halosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Halosaurus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Halosaurus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1366075;
}
