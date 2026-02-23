namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Iniidae.Inia;

/// <summary>
/// Species: Inia humboldtiana
/// NCBI TaxId: 3370120
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Inia_humboldtiana : Inia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Inia humboldtiana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Inia_humboldtiana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370120;
}
