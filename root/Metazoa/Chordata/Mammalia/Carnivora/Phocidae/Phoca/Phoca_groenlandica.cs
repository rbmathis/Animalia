namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Phoca;

/// <summary>
/// Species: Phoca groenlandica
/// NCBI TaxId: 39089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phoca_groenlandica : Phoca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phoca groenlandica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phoca_groenlandica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39089;
}
