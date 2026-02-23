namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Chaetomys;

/// <summary>
/// Species: Chaetomys subspinosus
/// NCBI TaxId: 480662
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetomys_subspinosus : Chaetomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetomys subspinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetomys_subspinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 480662;
}
