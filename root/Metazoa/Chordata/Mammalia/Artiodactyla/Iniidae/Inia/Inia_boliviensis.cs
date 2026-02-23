namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Iniidae.Inia;

/// <summary>
/// Species: Inia boliviensis
/// NCBI TaxId: 149089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Inia_boliviensis : Inia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Inia boliviensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Inia_boliviensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 149089;
}
