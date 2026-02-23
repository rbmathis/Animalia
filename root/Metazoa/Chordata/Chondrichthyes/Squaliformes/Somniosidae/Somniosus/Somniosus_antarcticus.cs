namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Somniosidae.Somniosus;

/// <summary>
/// Species: Somniosus antarcticus
/// NCBI TaxId: 428212
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Somniosus_antarcticus : Somniosus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Somniosus antarcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Somniosus_antarcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 428212;
}
