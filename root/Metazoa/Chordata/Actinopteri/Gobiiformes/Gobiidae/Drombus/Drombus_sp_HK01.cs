namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Drombus;

/// <summary>
/// Species: Drombus sp. HK01
/// NCBI TaxId: 3140082
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Drombus_sp_HK01 : Drombus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Drombus sp. HK01";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Drombus_sp_HK01";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3140082;
}
