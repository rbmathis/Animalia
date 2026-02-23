namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco biarmicus
/// NCBI TaxId: 345155
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_biarmicus : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco biarmicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_biarmicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 345155;
}
