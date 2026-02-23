namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Haliaeetus;

/// <summary>
/// Species: Haliaeetus pelagicus
/// NCBI TaxId: 52647
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Haliaeetus_pelagicus : Haliaeetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Haliaeetus pelagicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Haliaeetus_pelagicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52647;
}
