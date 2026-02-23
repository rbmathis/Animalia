namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrotilapia;

/// <summary>
/// Species: Petrotilapia sp. 'fuscus'
/// NCBI TaxId: 1608152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petrotilapia_sp_fuscus : Petrotilapia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petrotilapia sp. 'fuscus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petrotilapia_sp_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1608152;
}
