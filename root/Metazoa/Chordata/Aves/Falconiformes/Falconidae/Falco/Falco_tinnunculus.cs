namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco tinnunculus
/// NCBI TaxId: 100819
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_tinnunculus : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco tinnunculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_tinnunculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100819;
}
