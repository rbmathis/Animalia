namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Hydrobates;

/// <summary>
/// Species: Hydrobates pelagicus
/// NCBI TaxId: 79651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrobates_pelagicus : Hydrobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrobates pelagicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrobates_pelagicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79651;
}
