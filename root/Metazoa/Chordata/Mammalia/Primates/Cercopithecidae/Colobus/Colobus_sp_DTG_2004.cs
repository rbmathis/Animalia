namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus;

/// <summary>
/// Species: Colobus sp. DTG-2004
/// NCBI TaxId: 288544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colobus_sp_DTG_2004 : Colobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colobus sp. DTG-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colobus_sp_DTG_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 288544;
}
