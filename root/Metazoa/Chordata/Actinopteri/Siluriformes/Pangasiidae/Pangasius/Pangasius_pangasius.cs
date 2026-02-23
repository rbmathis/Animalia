namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius pangasius
/// NCBI TaxId: 8001
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_pangasius : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius pangasius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_pangasius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8001;
}
