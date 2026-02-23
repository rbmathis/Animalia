namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Carlia;

/// <summary>
/// Species: Carlia sp. TTWR-2003
/// NCBI TaxId: 221265
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carlia_sp_TTWR_2003 : Carlia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carlia sp. TTWR-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carlia_sp_TTWR_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221265;
}
