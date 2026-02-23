namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Species: Marmota menzbieri
/// NCBI TaxId: 93164
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmota_menzbieri : Marmota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmota menzbieri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmota_menzbieri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 93164;
}
