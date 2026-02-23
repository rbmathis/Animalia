namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ichthyomys;

/// <summary>
/// Species: Ichthyomys orientalis
/// NCBI TaxId: 3370116
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyomys_orientalis : Ichthyomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyomys orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyomys_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370116;
}
