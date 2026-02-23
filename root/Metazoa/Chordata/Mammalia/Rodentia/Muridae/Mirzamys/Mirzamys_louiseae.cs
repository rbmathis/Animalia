namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mirzamys;

/// <summary>
/// Species: Mirzamys louiseae
/// NCBI TaxId: 3148842
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mirzamys_louiseae : Mirzamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mirzamys louiseae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mirzamys_louiseae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148842;
}
