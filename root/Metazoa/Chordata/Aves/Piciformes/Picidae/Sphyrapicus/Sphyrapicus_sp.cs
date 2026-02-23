namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus;

/// <summary>
/// Species: Sphyrapicus sp.
/// NCBI TaxId: 2975257
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyrapicus_sp : Sphyrapicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyrapicus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyrapicus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2975257;
}
