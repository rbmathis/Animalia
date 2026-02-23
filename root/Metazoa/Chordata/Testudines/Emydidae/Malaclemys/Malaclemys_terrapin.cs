namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Malaclemys;

/// <summary>
/// Species: Malaclemys terrapin
/// NCBI TaxId: 8485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malaclemys_terrapin : Malaclemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malaclemys terrapin";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malaclemys_terrapin";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8485;
}
