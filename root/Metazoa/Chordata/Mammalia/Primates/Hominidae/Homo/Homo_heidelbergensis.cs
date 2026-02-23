namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo;

/// <summary>
/// Species: Homo heidelbergensis
/// NCBI TaxId: 1425170
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homo_heidelbergensis : Homo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homo heidelbergensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homo_heidelbergensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1425170;
}
