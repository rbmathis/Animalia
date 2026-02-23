namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Acryllium;

/// <summary>
/// Species: Acryllium vulturinum
/// NCBI TaxId: 8992
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acryllium_vulturinum : Acryllium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acryllium vulturinum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acryllium_vulturinum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8992;
}
