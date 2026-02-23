namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Pteromys;

/// <summary>
/// Species: Pteromys volans
/// NCBI TaxId: 55152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteromys_volans : Pteromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteromys volans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteromys_volans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55152;
}
