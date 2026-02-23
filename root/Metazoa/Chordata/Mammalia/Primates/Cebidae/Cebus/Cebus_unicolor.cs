namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus;

/// <summary>
/// Species: Cebus unicolor
/// NCBI TaxId: 1985288
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cebus_unicolor : Cebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cebus unicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cebus_unicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1985288;
}
