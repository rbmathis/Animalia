namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Frostius;

/// <summary>
/// Species: Frostius erythrophthalmus
/// NCBI TaxId: 1273207
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Frostius_erythrophthalmus : Frostius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Frostius erythrophthalmus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Frostius_erythrophthalmus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1273207;
}
