namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Craseomys;

/// <summary>
/// Species: Craseomys smithii
/// NCBI TaxId: 3369792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Craseomys_smithii : Craseomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Craseomys smithii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Craseomys_smithii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3369792;
}
