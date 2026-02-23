namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.environmental_samples;

/// <summary>
/// Species: Pangasianodon environmental sample
/// NCBI TaxId: 2002814
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasianodon_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasianodon environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasianodon_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2002814;
}
