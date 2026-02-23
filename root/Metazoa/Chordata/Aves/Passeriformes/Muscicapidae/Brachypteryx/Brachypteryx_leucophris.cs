namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Brachypteryx;

/// <summary>
/// Species: Brachypteryx leucophris
/// NCBI TaxId: 869899
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachypteryx_leucophris : Brachypteryx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachypteryx leucophris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachypteryx_leucophris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 869899;
}
