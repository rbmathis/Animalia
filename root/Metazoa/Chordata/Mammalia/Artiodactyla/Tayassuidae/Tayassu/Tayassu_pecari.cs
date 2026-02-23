namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Tayassu;

/// <summary>
/// Species: Tayassu pecari
/// NCBI TaxId: 30535
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tayassu_pecari : Tayassu
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tayassu pecari";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tayassu_pecari";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30535;
}
