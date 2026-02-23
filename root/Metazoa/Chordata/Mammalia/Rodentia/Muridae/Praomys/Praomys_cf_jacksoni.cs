namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys cf. jacksoni
/// NCBI TaxId: 666516
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_cf_jacksoni : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys cf. jacksoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_cf_jacksoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 666516;
}
