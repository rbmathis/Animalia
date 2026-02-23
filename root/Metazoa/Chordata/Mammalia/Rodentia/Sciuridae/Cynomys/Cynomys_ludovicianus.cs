namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Cynomys;

/// <summary>
/// Species: Cynomys ludovicianus
/// NCBI TaxId: 45480
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cynomys_ludovicianus : Cynomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cynomys ludovicianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cynomys_ludovicianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45480;
}
