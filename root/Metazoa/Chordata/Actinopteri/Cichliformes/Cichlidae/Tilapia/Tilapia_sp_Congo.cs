namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

/// <summary>
/// Species: Tilapia sp. 'Congo'
/// NCBI TaxId: 1652536
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tilapia_sp_Congo : Tilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tilapia sp. 'Congo'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tilapia_sp_Congo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1652536;
}
