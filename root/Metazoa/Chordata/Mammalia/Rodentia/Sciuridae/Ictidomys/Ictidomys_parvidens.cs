namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ictidomys;

/// <summary>
/// Species: Ictidomys parvidens
/// NCBI TaxId: 99846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ictidomys_parvidens : Ictidomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ictidomys parvidens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ictidomys_parvidens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 99846;
}
