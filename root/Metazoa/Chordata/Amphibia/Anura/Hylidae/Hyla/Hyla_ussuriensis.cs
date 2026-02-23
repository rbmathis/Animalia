namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla ussuriensis
/// NCBI TaxId: 1088778
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_ussuriensis : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla ussuriensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_ussuriensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1088778;
}
