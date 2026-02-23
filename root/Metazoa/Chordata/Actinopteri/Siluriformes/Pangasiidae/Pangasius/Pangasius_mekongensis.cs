namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius mekongensis
/// NCBI TaxId: 1769047
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_mekongensis : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius mekongensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_mekongensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1769047;
}
