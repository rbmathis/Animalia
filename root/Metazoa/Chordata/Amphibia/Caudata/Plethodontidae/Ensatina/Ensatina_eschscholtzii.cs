namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Ensatina;

/// <summary>
/// Species: Ensatina eschscholtzii
/// NCBI TaxId: 57550
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ensatina_eschscholtzii : Ensatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ensatina eschscholtzii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ensatina_eschscholtzii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57550;
}
