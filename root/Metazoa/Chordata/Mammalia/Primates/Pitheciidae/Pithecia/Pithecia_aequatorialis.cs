namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

/// <summary>
/// Species: Pithecia aequatorialis
/// NCBI TaxId: 2839867
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pithecia_aequatorialis : Pithecia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pithecia aequatorialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pithecia_aequatorialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2839867;
}
