namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Haliaeetus;

/// <summary>
/// Species: Haliaeetus leucoryphus
/// NCBI TaxId: 52646
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Haliaeetus_leucoryphus : Haliaeetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Haliaeetus leucoryphus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Haliaeetus_leucoryphus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52646;
}
