namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan;

/// <summary>
/// Species: Pan sp.
/// NCBI TaxId: 3612878
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pan_sp : Pan
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pan sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pan_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3612878;
}
