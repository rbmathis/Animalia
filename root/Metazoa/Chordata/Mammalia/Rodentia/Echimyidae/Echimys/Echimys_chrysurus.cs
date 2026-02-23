namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Echimys;

/// <summary>
/// Species: Echimys chrysurus
/// NCBI TaxId: 30621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Echimys_chrysurus : Echimys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Echimys chrysurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Echimys_chrysurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30621;
}
