namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Neomyxus;

/// <summary>
/// Species: Neomyxus leuciscus
/// NCBI TaxId: 1111478
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neomyxus_leuciscus : Neomyxus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neomyxus leuciscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neomyxus_leuciscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1111478;
}
