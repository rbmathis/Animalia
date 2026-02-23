namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus labiatus
/// NCBI TaxId: 78454
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_labiatus : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus labiatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_labiatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 78454;
}
