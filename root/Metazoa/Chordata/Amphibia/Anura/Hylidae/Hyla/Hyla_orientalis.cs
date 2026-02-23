namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla orientalis
/// NCBI TaxId: 565009
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_orientalis : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 565009;
}
