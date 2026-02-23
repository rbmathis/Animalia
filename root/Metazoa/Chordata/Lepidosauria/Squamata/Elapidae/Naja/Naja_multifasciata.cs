namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja multifasciata
/// NCBI TaxId: 111947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_multifasciata : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja multifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_multifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111947;
}
