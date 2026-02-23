namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ictidomys;

/// <summary>
/// Species: Ictidomys tridecemlineatus
/// NCBI TaxId: 43179
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ictidomys_tridecemlineatus : Ictidomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ictidomys tridecemlineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ictidomys_tridecemlineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43179;
}
