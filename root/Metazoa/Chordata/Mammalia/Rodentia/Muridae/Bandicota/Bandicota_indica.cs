namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Bandicota;

/// <summary>
/// Species: Bandicota indica
/// NCBI TaxId: 456472
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bandicota_indica : Bandicota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bandicota indica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bandicota_indica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 456472;
}
