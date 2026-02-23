namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hylophorbus;

/// <summary>
/// Species: Hylophorbus sp. 'Milne Bay'
/// NCBI TaxId: 3052075
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylophorbus_sp_Milne_Bay : Hylophorbus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylophorbus sp. 'Milne Bay'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylophorbus_sp_Milne_Bay";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3052075;
}
