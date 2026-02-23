namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cuniculidae.Cuniculus;

/// <summary>
/// Species: Cuniculus taczanowskii
/// NCBI TaxId: 143288
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuniculus_taczanowskii : Cuniculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuniculus taczanowskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuniculus_taczanowskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143288;
}
