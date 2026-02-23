namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinus;

/// <summary>
/// Species: Cyprinus carpio
/// NCBI TaxId: 7962
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyprinus_carpio : Cyprinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyprinus carpio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyprinus_carpio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7962;
}
