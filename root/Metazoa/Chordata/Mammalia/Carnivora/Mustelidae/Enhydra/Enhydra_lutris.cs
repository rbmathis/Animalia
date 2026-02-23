namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Enhydra;

/// <summary>
/// Species: Enhydra lutris
/// NCBI TaxId: 34882
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Enhydra_lutris : Enhydra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Enhydra lutris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Enhydra_lutris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34882;
}
