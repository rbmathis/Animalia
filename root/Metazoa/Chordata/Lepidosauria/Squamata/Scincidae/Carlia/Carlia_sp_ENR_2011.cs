namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carlia;

/// <summary>
/// Species: Carlia sp. ENR-2011
/// NCBI TaxId: 1075796
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carlia_sp_ENR_2011 : Carlia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carlia sp. ENR-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carlia_sp_ENR_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1075796;
}
