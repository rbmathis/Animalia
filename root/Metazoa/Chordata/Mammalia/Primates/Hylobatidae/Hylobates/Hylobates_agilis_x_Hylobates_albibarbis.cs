namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Species: Hylobates agilis x Hylobates albibarbis
/// NCBI TaxId: 2768845
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylobates_agilis_x_Hylobates_albibarbis : Hylobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylobates agilis x Hylobates albibarbis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylobates_agilis_x_Hylobates_albibarbis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2768845;
}
