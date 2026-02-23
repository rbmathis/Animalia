namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Salamandrina;

/// <summary>
/// Species: Salamandrina terdigitata
/// NCBI TaxId: 305979
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salamandrina_terdigitata : Salamandrina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salamandrina terdigitata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salamandrina_terdigitata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 305979;
}
