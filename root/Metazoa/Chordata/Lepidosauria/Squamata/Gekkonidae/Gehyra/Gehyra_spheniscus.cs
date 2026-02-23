namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gehyra;

/// <summary>
/// Species: Gehyra spheniscus
/// NCBI TaxId: 1338039
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gehyra_spheniscus : Gehyra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gehyra spheniscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gehyra_spheniscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1338039;
}
