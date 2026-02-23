namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius sp. BSBJ2
/// NCBI TaxId: 2904005
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_sp_BSBJ2 : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius sp. BSBJ2";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_sp_BSBJ2";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2904005;
}
