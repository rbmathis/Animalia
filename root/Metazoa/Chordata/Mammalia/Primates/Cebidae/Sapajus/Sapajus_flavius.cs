namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Sapajus;

/// <summary>
/// Species: Sapajus flavius
/// NCBI TaxId: 1112861
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sapajus_flavius : Sapajus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sapajus flavius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sapajus_flavius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1112861;
}
