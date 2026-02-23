namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Brachypteryx;

/// <summary>
/// Species: Brachypteryx sinensis
/// NCBI TaxId: 2518300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachypteryx_sinensis : Brachypteryx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachypteryx sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachypteryx_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2518300;
}
