namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser stellatus
/// NCBI TaxId: 7903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_stellatus : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser stellatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_stellatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7903;
}
