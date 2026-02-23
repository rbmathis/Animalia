namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Parus;

/// <summary>
/// Species: Parus cinereus
/// NCBI TaxId: 1356362
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parus_cinereus : Parus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parus cinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parus_cinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1356362;
}
