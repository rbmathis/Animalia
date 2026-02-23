namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Clemmys;

/// <summary>
/// Species: Clemmys guttata
/// NCBI TaxId: 85608
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clemmys_guttata : Clemmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clemmys guttata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clemmys_guttata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85608;
}
