namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardea;

/// <summary>
/// Species: Ardea purpurea
/// NCBI TaxId: 188373
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ardea_purpurea : Ardea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ardea purpurea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ardea_purpurea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 188373;
}
