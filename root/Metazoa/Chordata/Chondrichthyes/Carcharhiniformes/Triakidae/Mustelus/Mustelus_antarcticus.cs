namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Mustelus;

/// <summary>
/// Species: Mustelus antarcticus
/// NCBI TaxId: 7813
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustelus_antarcticus : Mustelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustelus antarcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustelus_antarcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7813;
}
