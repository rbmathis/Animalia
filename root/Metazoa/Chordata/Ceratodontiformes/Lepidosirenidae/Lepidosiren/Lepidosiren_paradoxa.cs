namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae.Lepidosiren;

/// <summary>
/// Species: Lepidosiren paradoxa
/// NCBI TaxId: 7883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidosiren_paradoxa : Lepidosiren
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidosiren paradoxa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidosiren_paradoxa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7883;
}
