namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius heterolepis
/// NCBI TaxId: 1642189
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_heterolepis : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius heterolepis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_heterolepis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1642189;
}
