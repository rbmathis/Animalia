namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Loxodonta;

/// <summary>
/// Species: Loxodonta cyclotis x africana
/// NCBI TaxId: 169825
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loxodonta_cyclotis_x_africana : Loxodonta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loxodonta cyclotis x africana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loxodonta_cyclotis_x_africana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 169825;
}
