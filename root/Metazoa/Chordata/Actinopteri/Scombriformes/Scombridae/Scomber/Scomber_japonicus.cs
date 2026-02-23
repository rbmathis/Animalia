namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomber;

/// <summary>
/// Species: Scomber japonicus
/// NCBI TaxId: 13676
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scomber_japonicus : Scomber
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scomber japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scomber_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13676;
}
