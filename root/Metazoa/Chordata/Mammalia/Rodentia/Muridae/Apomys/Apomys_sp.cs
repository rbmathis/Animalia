namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apomys;

/// <summary>
/// Species: Apomys sp.
/// NCBI TaxId: 3457170
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apomys_sp : Apomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3457170;
}
