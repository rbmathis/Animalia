namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Species: Hapalemur meridionalis
/// NCBI TaxId: 3043112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalemur_meridionalis : Hapalemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalemur meridionalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalemur_meridionalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3043112;
}
