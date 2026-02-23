namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Otospermophilus;

/// <summary>
/// Species: Otospermophilus variegatus
/// NCBI TaxId: 45472
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otospermophilus_variegatus : Otospermophilus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otospermophilus variegatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otospermophilus_variegatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45472;
}
