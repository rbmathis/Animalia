namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Conger;

/// <summary>
/// Species: Conger sp. 1MFL
/// NCBI TaxId: 2890394
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Conger_sp_1MFL : Conger
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Conger sp. 1MFL";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Conger_sp_1MFL";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2890394;
}
