namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Furcifer;

/// <summary>
/// Species: Furcifer rhinoceratus
/// NCBI TaxId: 1175239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Furcifer_rhinoceratus : Furcifer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Furcifer rhinoceratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Furcifer_rhinoceratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1175239;
}
