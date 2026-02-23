namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius sp. ZZSH-2001
/// NCBI TaxId: 161275
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_sp_ZZSH_2001 : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius sp. ZZSH-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_sp_ZZSH_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161275;
}
