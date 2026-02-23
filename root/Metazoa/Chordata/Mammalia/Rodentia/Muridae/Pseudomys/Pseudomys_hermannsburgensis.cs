namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pseudomys;

/// <summary>
/// Species: Pseudomys hermannsburgensis
/// NCBI TaxId: 221913
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudomys_hermannsburgensis : Pseudomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudomys hermannsburgensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudomys_hermannsburgensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221913;
}
