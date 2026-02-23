namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Lagostomus;

/// <summary>
/// Species: Lagostomus maximus
/// NCBI TaxId: 10154
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagostomus_maximus : Lagostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagostomus maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagostomus_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10154;
}
