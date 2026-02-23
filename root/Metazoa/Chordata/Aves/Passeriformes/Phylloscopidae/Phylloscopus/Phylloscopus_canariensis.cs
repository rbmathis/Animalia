namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus;

/// <summary>
/// Species: Phylloscopus canariensis
/// NCBI TaxId: 52911
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phylloscopus_canariensis : Phylloscopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phylloscopus canariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phylloscopus_canariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52911;
}
