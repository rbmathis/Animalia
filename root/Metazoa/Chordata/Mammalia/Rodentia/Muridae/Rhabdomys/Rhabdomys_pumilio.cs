namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhabdomys;

/// <summary>
/// Species: Rhabdomys pumilio
/// NCBI TaxId: 121573
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhabdomys_pumilio : Rhabdomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhabdomys pumilio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhabdomys_pumilio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121573;
}
