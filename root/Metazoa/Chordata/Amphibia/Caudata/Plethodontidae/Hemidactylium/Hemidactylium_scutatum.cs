namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Hemidactylium;

/// <summary>
/// Species: Hemidactylium scutatum
/// NCBI TaxId: 291265
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemidactylium_scutatum : Hemidactylium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemidactylium scutatum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemidactylium_scutatum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 291265;
}
