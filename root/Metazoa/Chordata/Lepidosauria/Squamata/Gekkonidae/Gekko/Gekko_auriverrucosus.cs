namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko auriverrucosus
/// NCBI TaxId: 515998
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_auriverrucosus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko auriverrucosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_auriverrucosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 515998;
}
