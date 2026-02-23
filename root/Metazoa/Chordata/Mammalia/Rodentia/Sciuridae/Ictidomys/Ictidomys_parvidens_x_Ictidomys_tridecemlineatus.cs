namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ictidomys;

/// <summary>
/// Species: Ictidomys parvidens x Ictidomys tridecemlineatus
/// NCBI TaxId: 1248327
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ictidomys_parvidens_x_Ictidomys_tridecemlineatus : Ictidomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ictidomys parvidens x Ictidomys tridecemlineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ictidomys_parvidens_x_Ictidomys_tridecemlineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1248327;
}
