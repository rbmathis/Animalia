namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Vulpes;

/// <summary>
/// Species: Vulpes environmental sample
/// NCBI TaxId: 1002255
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vulpes_environmental_sample : Vulpes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vulpes environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vulpes_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002255;
}
