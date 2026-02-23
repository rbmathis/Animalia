namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja annulata
/// NCBI TaxId: 8609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_annulata : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja annulata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_annulata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8609;
}
