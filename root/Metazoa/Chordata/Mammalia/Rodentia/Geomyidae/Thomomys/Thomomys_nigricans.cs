namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Thomomys;

/// <summary>
/// Species: Thomomys nigricans
/// NCBI TaxId: 1387314
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thomomys_nigricans : Thomomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thomomys nigricans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thomomys_nigricans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1387314;
}
