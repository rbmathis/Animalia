namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Calumma;

/// <summary>
/// Species: Calumma aff. nasutum
/// NCBI TaxId: 1128974
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calumma_aff_nasutum : Calumma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calumma aff. nasutum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calumma_aff_nasutum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1128974;
}
