namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko kikuchii
/// NCBI TaxId: 1367210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_kikuchii : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko kikuchii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_kikuchii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1367210;
}
