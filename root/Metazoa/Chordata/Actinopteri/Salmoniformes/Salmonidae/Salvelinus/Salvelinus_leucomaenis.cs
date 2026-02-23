namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salvelinus;

/// <summary>
/// Species: Salvelinus leucomaenis
/// NCBI TaxId: 8034
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salvelinus_leucomaenis : Salvelinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salvelinus leucomaenis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salvelinus_leucomaenis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8034;
}
