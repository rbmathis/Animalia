namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Corynorhinus;

/// <summary>
/// Species: Corynorhinus mexicanus
/// NCBI TaxId: 712049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corynorhinus_mexicanus : Corynorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corynorhinus mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corynorhinus_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 712049;
}
