namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius elongatus
/// NCBI TaxId: 1769046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_elongatus : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius elongatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_elongatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1769046;
}
