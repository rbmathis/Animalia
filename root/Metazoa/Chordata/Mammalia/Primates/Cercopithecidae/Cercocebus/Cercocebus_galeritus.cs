namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercocebus;

/// <summary>
/// Species: Cercocebus galeritus
/// NCBI TaxId: 9532
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercocebus_galeritus : Cercocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercocebus galeritus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercocebus_galeritus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9532;
}
