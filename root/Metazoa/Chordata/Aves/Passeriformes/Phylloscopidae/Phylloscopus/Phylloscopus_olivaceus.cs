namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus;

/// <summary>
/// Species: Phylloscopus olivaceus
/// NCBI TaxId: 573050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phylloscopus_olivaceus : Phylloscopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phylloscopus olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phylloscopus_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 573050;
}
