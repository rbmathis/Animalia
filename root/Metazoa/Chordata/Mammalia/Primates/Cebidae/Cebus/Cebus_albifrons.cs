namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus;

/// <summary>
/// Species: Cebus albifrons
/// NCBI TaxId: 9514
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cebus_albifrons : Cebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cebus albifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cebus_albifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9514;
}
