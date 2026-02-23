namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

/// <summary>
/// Species: Carassius sp. allopolyploid
/// NCBI TaxId: 3414683
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carassius_sp_allopolyploid : Carassius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carassius sp. allopolyploid";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carassius_sp_allopolyploid";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3414683;
}
