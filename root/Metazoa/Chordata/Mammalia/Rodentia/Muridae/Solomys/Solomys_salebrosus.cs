namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Solomys;

/// <summary>
/// Species: Solomys salebrosus
/// NCBI TaxId: 442621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Solomys_salebrosus : Solomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Solomys salebrosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Solomys_salebrosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442621;
}
