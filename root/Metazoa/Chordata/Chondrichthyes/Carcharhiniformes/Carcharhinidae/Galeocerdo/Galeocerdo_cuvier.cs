namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Galeocerdo;

/// <summary>
/// Species: Galeocerdo cuvier
/// NCBI TaxId: 7819
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galeocerdo_cuvier : Galeocerdo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galeocerdo cuvier";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galeocerdo_cuvier";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7819;
}
