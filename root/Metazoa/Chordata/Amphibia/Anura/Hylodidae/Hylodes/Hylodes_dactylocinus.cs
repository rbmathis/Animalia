namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Hylodes;

/// <summary>
/// Species: Hylodes dactylocinus
/// NCBI TaxId: 209676
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylodes_dactylocinus : Hylodes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylodes dactylocinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylodes_dactylocinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 209676;
}
