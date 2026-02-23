namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Species: Marmota marmota
/// NCBI TaxId: 9993
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmota_marmota : Marmota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmota marmota";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmota_marmota";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9993;
}
