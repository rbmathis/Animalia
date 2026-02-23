namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Sphyrapicus;

/// <summary>
/// Species: Sphyrapicus nuchalis
/// NCBI TaxId: 372291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyrapicus_nuchalis : Sphyrapicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyrapicus nuchalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyrapicus_nuchalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 372291;
}
