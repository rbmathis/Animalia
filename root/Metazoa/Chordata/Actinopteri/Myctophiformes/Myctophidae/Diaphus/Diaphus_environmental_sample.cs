namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diaphus;

/// <summary>
/// Species: Diaphus environmental sample
/// NCBI TaxId: 1366069
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diaphus_environmental_sample : Diaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diaphus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diaphus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1366069;
}
