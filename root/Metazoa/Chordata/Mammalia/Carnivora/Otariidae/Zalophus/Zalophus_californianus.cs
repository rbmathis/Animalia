namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Zalophus;

/// <summary>
/// Species: Zalophus californianus
/// NCBI TaxId: 9704
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zalophus_californianus : Zalophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zalophus californianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zalophus_californianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9704;
}
