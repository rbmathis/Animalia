namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko ulikovskii
/// NCBI TaxId: 742354
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_ulikovskii : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko ulikovskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_ulikovskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 742354;
}
