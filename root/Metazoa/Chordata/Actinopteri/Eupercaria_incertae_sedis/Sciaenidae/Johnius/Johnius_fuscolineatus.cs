namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius fuscolineatus
/// NCBI TaxId: 1003746
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_fuscolineatus : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius fuscolineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_fuscolineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003746;
}
