namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus;

/// <summary>
/// Species: Colobus vellerosus
/// NCBI TaxId: 378195
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colobus_vellerosus : Colobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colobus vellerosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colobus_vellerosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 378195;
}
