namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Conepatus;

/// <summary>
/// Species: Conepatus leuconotus
/// NCBI TaxId: 30543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Conepatus_leuconotus : Conepatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Conepatus leuconotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Conepatus_leuconotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30543;
}
