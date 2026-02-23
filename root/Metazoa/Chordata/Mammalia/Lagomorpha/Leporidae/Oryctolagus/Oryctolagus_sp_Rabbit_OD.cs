namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Oryctolagus;

/// <summary>
/// Species: Oryctolagus sp. 'Rabbit_OD'
/// NCBI TaxId: 2665958
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oryctolagus_sp_Rabbit_OD : Oryctolagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oryctolagus sp. 'Rabbit_OD'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oryctolagus_sp_Rabbit_OD";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2665958;
}
