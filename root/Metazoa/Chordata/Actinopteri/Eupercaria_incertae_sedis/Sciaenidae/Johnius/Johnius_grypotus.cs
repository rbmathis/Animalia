namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

/// <summary>
/// Species: Johnius grypotus
/// NCBI TaxId: 1302737
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Johnius_grypotus : Johnius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Johnius grypotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Johnius_grypotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1302737;
}
