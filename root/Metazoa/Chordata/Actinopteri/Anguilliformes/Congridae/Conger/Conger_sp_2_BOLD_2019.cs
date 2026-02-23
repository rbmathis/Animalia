namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Conger;

/// <summary>
/// Species: Conger sp. 2 BOLD-2019
/// NCBI TaxId: 2579499
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Conger_sp_2_BOLD_2019 : Conger
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Conger sp. 2 BOLD-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Conger_sp_2_BOLD_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2579499;
}
