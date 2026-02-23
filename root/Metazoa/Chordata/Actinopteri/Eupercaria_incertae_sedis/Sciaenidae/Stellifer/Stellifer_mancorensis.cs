namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Stellifer;

/// <summary>
/// Species: Stellifer mancorensis
/// NCBI TaxId: 3001046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stellifer_mancorensis : Stellifer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stellifer mancorensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stellifer_mancorensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3001046;
}
