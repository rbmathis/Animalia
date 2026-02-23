namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Veniliornis;

/// <summary>
/// Species: Veniliornis sanguineus
/// NCBI TaxId: 1118852
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Veniliornis_sanguineus : Veniliornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Veniliornis sanguineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Veniliornis_sanguineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118852;
}
