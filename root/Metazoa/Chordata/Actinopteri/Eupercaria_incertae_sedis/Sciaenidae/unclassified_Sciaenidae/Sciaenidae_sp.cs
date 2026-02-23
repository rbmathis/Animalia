namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.unclassified_Sciaenidae;

/// <summary>
/// Species: Sciaenidae sp.
/// NCBI TaxId: 3444665
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciaenidae_sp : unclassified_Sciaenidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciaenidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciaenidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3444665;
}
