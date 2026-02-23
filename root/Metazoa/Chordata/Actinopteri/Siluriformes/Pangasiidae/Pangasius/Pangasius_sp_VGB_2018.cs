namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pangasiidae.Pangasius;

/// <summary>
/// Species: Pangasius sp. VGB-2018
/// NCBI TaxId: 2161644
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pangasius_sp_VGB_2018 : Pangasius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pangasius sp. VGB-2018";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pangasius_sp_VGB_2018";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2161644;
}
