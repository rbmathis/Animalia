namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gekko;

/// <summary>
/// Species: Gekko petricolus
/// NCBI TaxId: 1085618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gekko_petricolus : Gekko
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gekko petricolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gekko_petricolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1085618;
}
