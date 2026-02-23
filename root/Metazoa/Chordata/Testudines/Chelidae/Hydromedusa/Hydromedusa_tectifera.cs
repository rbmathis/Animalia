namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Hydromedusa;

/// <summary>
/// Species: Hydromedusa tectifera
/// NCBI TaxId: 61327
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydromedusa_tectifera : Hydromedusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydromedusa tectifera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydromedusa_tectifera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61327;
}
