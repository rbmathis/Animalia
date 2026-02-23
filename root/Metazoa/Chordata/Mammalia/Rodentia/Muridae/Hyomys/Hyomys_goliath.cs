namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hyomys;

/// <summary>
/// Species: Hyomys goliath
/// NCBI TaxId: 337221
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyomys_goliath : Hyomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyomys goliath";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyomys_goliath";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 337221;
}
