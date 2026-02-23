namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla sarda
/// NCBI TaxId: 327740
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_sarda : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla sarda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_sarda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 327740;
}
