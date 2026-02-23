namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Loxodonta;

/// <summary>
/// Species: Loxodonta africana
/// NCBI TaxId: 9785
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loxodonta_africana : Loxodonta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loxodonta africana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loxodonta_africana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9785;
}
