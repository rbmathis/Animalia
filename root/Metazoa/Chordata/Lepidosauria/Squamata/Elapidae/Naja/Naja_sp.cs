namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja sp.
/// NCBI TaxId: 3123106
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_sp : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3123106;
}
