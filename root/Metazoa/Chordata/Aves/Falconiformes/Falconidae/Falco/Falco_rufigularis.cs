namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco rufigularis
/// NCBI TaxId: 399590
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_rufigularis : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco rufigularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_rufigularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 399590;
}
