namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae.Miniopterus;

/// <summary>
/// Species: Miniopterus sp.
/// NCBI TaxId: 3075049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Miniopterus_sp : Miniopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Miniopterus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Miniopterus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3075049;
}
