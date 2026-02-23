namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoungulata.Toxodontidae.Toxodon;

/// <summary>
/// Species: Toxodon sp. FW-2014
/// NCBI TaxId: 1563122
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Toxodon_sp_FW_2014 : Toxodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Toxodon sp. FW-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Toxodon_sp_FW_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1563122;
}
