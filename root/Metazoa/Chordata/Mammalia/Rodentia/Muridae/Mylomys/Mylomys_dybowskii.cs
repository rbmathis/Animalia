namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mylomys;

/// <summary>
/// Species: Mylomys dybowskii
/// NCBI TaxId: 121581
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mylomys_dybowskii : Mylomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mylomys dybowskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mylomys_dybowskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121581;
}
