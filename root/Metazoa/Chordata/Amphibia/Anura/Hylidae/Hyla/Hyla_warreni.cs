namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla warreni
/// NCBI TaxId: 1221494
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_warreni : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla warreni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_warreni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1221494;
}
