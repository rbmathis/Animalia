namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Microgobius;

/// <summary>
/// Species: Microgobius urraca
/// NCBI TaxId: 1234903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microgobius_urraca : Microgobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microgobius urraca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microgobius_urraca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234903;
}
