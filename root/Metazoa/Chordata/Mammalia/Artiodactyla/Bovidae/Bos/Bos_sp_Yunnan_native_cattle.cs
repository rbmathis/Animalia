namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Species: Bos sp. Yunnan native cattle
/// NCBI TaxId: 3144842
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bos_sp_Yunnan_native_cattle : Bos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bos sp. Yunnan native cattle";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bos_sp_Yunnan_native_cattle";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3144842;
}
