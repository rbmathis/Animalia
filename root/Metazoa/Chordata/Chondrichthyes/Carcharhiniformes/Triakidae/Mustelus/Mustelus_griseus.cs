namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Mustelus;

/// <summary>
/// Species: Mustelus griseus
/// NCBI TaxId: 89020
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustelus_griseus : Mustelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustelus griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustelus_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89020;
}
