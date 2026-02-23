namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Iniidae.Inia;

/// <summary>
/// Species: Inia araguaiaensis
/// NCBI TaxId: 1454009
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Inia_araguaiaensis : Inia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Inia araguaiaensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Inia_araguaiaensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1454009;
}
