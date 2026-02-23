namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Haliaeetus;

/// <summary>
/// Species: Haliaeetus albicilla
/// NCBI TaxId: 8969
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Haliaeetus_albicilla : Haliaeetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Haliaeetus albicilla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Haliaeetus_albicilla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8969;
}
