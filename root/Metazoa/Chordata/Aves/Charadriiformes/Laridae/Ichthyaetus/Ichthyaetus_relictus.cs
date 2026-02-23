namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Ichthyaetus;

/// <summary>
/// Species: Ichthyaetus relictus
/// NCBI TaxId: 328046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyaetus_relictus : Ichthyaetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyaetus relictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyaetus_relictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 328046;
}
