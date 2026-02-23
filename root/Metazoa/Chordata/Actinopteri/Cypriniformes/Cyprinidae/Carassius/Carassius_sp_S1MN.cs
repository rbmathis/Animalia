namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

/// <summary>
/// Species: Carassius sp. S1MN
/// NCBI TaxId: 870600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carassius_sp_S1MN : Carassius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carassius sp. S1MN";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carassius_sp_S1MN";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 870600;
}
