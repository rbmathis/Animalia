namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Calumma;

/// <summary>
/// Species: Calumma sp. 1
/// NCBI TaxId: 3053426
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calumma_sp_1 : Calumma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calumma sp. 1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calumma_sp_1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3053426;
}
