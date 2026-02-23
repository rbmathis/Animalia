namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pachyurus;

/// <summary>
/// Species: Pachyurus sp. 'Para'
/// NCBI TaxId: 1241938
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachyurus_sp_Para : Pachyurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachyurus sp. 'Para'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachyurus_sp_Para";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1241938;
}
