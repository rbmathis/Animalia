namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.unclassified_Columbiformes;

/// <summary>
/// Species: Columbiformes sp.
/// NCBI TaxId: 2805849
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Columbiformes_sp : unclassified_Columbiformes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Columbiformes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Columbiformes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2805849;
}
