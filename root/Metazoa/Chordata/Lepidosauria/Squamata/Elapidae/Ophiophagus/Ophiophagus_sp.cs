namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ophiophagus;

/// <summary>
/// Species: Ophiophagus sp.
/// NCBI TaxId: 31146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ophiophagus_sp : Ophiophagus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ophiophagus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ophiophagus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 31146;
}
