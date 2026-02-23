namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Lacerta;

/// <summary>
/// Species: Lacerta pamphylica
/// NCBI TaxId: 95621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lacerta_pamphylica : Lacerta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lacerta pamphylica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lacerta_pamphylica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95621;
}
