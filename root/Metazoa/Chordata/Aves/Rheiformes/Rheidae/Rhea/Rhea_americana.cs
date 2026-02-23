namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Rheiformes.Rheidae.Rhea;

/// <summary>
/// Species: Rhea americana
/// NCBI TaxId: 8797
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhea_americana : Rhea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhea americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhea_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8797;
}
