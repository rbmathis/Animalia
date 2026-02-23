namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mesocricetus;

/// <summary>
/// Species: Mesocricetus sp.
/// NCBI TaxId: 10038
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesocricetus_sp : Mesocricetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesocricetus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesocricetus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10038;
}
