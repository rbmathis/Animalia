namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus;

/// <summary>
/// Species: Anthus campestris
/// NCBI TaxId: 45800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anthus_campestris : Anthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anthus campestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anthus_campestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45800;
}
