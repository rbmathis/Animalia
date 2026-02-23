namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Antrostomus;

/// <summary>
/// Species: Antrostomus carolinensis
/// NCBI TaxId: 279965
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Antrostomus_carolinensis : Antrostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Antrostomus carolinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Antrostomus_carolinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279965;
}
