namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco severus
/// NCBI TaxId: 495965
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_severus : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco severus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_severus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 495965;
}
