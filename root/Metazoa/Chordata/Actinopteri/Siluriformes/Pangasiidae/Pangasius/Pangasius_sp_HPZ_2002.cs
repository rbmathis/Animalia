namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius sp. HPZ-2002
/// NCBI TaxId: 195048
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_sp_HPZ_2002 : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius sp. HPZ-2002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_sp_HPZ_2002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 195048;
}
