namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrotilapia;

/// <summary>
/// Species: Petrotilapia sp. 'black flank'
/// NCBI TaxId: 3385392
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petrotilapia_sp_black_flank : Petrotilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petrotilapia sp. 'black flank'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petrotilapia_sp_black_flank";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3385392;
}
