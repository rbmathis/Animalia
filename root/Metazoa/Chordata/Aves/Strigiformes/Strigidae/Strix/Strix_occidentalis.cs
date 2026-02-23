namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Strix;

/// <summary>
/// Species: Strix occidentalis
/// NCBI TaxId: 201991
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Strix_occidentalis : Strix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Strix occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Strix_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 201991;
}
