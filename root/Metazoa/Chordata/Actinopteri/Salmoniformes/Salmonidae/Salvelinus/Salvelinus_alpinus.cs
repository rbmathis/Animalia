namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salvelinus;

/// <summary>
/// Species: Salvelinus alpinus
/// NCBI TaxId: 8036
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salvelinus_alpinus : Salvelinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salvelinus alpinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salvelinus_alpinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8036;
}
