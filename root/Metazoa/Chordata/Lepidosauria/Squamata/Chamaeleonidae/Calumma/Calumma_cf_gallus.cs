namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Calumma;

/// <summary>
/// Species: Calumma cf. gallus
/// NCBI TaxId: 1128973
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calumma_cf_gallus : Calumma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calumma cf. gallus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calumma_cf_gallus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1128973;
}
