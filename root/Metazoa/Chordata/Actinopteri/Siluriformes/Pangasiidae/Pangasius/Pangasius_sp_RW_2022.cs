namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius sp. RW-2022
/// NCBI TaxId: 2937456
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_sp_RW_2022 : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius sp. RW-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_sp_RW_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2937456;
}
