namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus;

/// <summary>
/// Species: Sphyrapicus varius
/// NCBI TaxId: 56079
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyrapicus_varius : Sphyrapicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyrapicus varius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyrapicus_varius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56079;
}
