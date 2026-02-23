namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Aegialomys;

/// <summary>
/// Species: Aegialomys galapagoensis
/// NCBI TaxId: 530170
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aegialomys_galapagoensis : Aegialomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aegialomys galapagoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aegialomys_galapagoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 530170;
}
