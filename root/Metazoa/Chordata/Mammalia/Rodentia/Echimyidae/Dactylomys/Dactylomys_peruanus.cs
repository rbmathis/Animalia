namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Dactylomys;

/// <summary>
/// Species: Dactylomys peruanus
/// NCBI TaxId: 490301
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dactylomys_peruanus : Dactylomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dactylomys peruanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dactylomys_peruanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 490301;
}
