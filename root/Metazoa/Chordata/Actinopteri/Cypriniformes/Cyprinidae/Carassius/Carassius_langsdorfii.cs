namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

/// <summary>
/// Species: Carassius langsdorfii
/// NCBI TaxId: 138676
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carassius_langsdorfii : Carassius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carassius langsdorfii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carassius_langsdorfii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 138676;
}
