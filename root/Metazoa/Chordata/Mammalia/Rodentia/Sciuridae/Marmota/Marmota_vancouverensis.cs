namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Species: Marmota vancouverensis
/// NCBI TaxId: 93167
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmota_vancouverensis : Marmota
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmota vancouverensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmota_vancouverensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 93167;
}
