namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardina;

/// <summary>
/// Species: Sardina pilchardus
/// NCBI TaxId: 27697
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardina_pilchardus : Sardina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardina pilchardus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardina_pilchardus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27697;
}
