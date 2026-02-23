namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan;

/// <summary>
/// Species: Pan troglodytes
/// NCBI TaxId: 9598
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pan_troglodytes : Pan
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pan troglodytes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pan_troglodytes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9598;
}
