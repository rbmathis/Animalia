namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius sp. NBFGR/PANPTAM.11
/// NCBI TaxId: 2883149
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_sp_NBFGRPANPTAM11 : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius sp. NBFGR/PANPTAM.11";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_sp_NBFGRPANPTAM11";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2883149;
}
