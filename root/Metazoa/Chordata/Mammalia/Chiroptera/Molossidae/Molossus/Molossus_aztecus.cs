namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossus;

/// <summary>
/// Species: Molossus aztecus
/// NCBI TaxId: 2116674
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Molossus_aztecus : Molossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Molossus aztecus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Molossus_aztecus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2116674;
}
