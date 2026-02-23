namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Species: Marmota monax
/// NCBI TaxId: 9995
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmota_monax : Marmota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmota monax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmota_monax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9995;
}
