namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Naja;

/// <summary>
/// Species: Naja melanoleuca
/// NCBI TaxId: 8643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Naja_melanoleuca : Naja
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Naja melanoleuca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Naja_melanoleuca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8643;
}
