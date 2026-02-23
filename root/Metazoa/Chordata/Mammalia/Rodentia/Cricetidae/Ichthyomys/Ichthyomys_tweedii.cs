namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ichthyomys;

/// <summary>
/// Species: Ichthyomys tweedii
/// NCBI TaxId: 2928172
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyomys_tweedii : Ichthyomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyomys tweedii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyomys_tweedii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2928172;
}
