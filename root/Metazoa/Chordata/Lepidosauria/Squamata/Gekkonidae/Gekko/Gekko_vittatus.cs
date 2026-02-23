namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko vittatus
/// NCBI TaxId: 278186
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_vittatus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko vittatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_vittatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 278186;
}
