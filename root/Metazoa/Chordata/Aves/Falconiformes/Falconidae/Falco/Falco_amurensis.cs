namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco amurensis
/// NCBI TaxId: 495945
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_amurensis : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco amurensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_amurensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 495945;
}
