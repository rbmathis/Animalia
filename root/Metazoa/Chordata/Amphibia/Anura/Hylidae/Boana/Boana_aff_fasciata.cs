namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Boana;

/// <summary>
/// Species: Boana aff. fasciata
/// NCBI TaxId: 3447362
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Boana_aff_fasciata : Boana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Boana aff. fasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Boana_aff_fasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3447362;
}
