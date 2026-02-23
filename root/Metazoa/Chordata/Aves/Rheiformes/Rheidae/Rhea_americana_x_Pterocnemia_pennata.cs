namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Rheiformes.Rheidae;

/// <summary>
/// Species: Rhea americana x Pterocnemia pennata
/// NCBI TaxId: 186442
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhea_americana_x_Pterocnemia_pennata : Rheidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhea americana x Pterocnemia pennata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhea_americana_x_Pterocnemia_pennata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 186442;
}
