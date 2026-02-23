namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

/// <summary>
/// Species: Otomys cf. saundersiae
/// NCBI TaxId: 635072
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otomys_cf_saundersiae : Otomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otomys cf. saundersiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otomys_cf_saundersiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 635072;
}
