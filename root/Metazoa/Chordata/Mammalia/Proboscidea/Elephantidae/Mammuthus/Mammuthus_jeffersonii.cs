namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Mammuthus;

/// <summary>
/// Species: Mammuthus jeffersonii
/// NCBI TaxId: 1851652
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammuthus_jeffersonii : Mammuthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammuthus jeffersonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammuthus_jeffersonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1851652;
}
