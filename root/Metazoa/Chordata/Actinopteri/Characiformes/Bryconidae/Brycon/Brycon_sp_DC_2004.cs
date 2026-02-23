namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon;

/// <summary>
/// Species: Brycon sp. DC-2004
/// NCBI TaxId: 303985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brycon_sp_DC_2004 : Brycon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brycon sp. DC-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brycon_sp_DC_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303985;
}
