namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla helenae
/// NCBI TaxId: 1329754
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_helenae : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla helenae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_helenae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1329754;
}
