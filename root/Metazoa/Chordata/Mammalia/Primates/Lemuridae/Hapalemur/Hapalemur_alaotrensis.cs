namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Species: Hapalemur alaotrensis
/// NCBI TaxId: 3370048
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalemur_alaotrensis : Hapalemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalemur alaotrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalemur_alaotrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370048;
}
