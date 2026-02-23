namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Cuon;

/// <summary>
/// Species: Cuon alpinus
/// NCBI TaxId: 68730
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuon_alpinus : Cuon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuon alpinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuon_alpinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68730;
}
