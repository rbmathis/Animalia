namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla cf. meridionalis MS-2008
/// NCBI TaxId: 565007
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_cf_meridionalis_MS_2008 : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla cf. meridionalis MS-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_cf_meridionalis_MS_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 565007;
}
