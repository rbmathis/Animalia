namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Balitora;

/// <summary>
/// Species: Balitora sp. 'INLE'
/// NCBI TaxId: 1907122
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balitora_sp_INLE : Balitora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balitora sp. 'INLE'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balitora_sp_INLE";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1907122;
}
