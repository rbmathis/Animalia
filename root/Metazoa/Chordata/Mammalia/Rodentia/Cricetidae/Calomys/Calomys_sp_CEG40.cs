namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys sp. CEG40
/// NCBI TaxId: 378674
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_sp_CEG40 : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys sp. CEG40";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_sp_CEG40";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 378674;
}
