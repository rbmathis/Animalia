namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius dussumieri
/// NCBI TaxId: 459284
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_dussumieri : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius dussumieri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_dussumieri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 459284;
}
