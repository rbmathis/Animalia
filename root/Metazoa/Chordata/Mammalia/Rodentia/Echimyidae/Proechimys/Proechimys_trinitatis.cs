namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Proechimys;

/// <summary>
/// Species: Proechimys trinitatis
/// NCBI TaxId: 2033321
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Proechimys_trinitatis : Proechimys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Proechimys trinitatis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Proechimys_trinitatis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2033321;
}
