namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pica;

/// <summary>
/// Species: Pica pica
/// NCBI TaxId: 34924
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pica_pica : Pica
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pica pica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pica_pica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34924;
}
