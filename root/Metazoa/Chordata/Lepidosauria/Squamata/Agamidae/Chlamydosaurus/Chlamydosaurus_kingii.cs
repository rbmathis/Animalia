namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Chlamydosaurus;

/// <summary>
/// Species: Chlamydosaurus kingii
/// NCBI TaxId: 103699
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlamydosaurus_kingii : Chlamydosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlamydosaurus kingii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlamydosaurus_kingii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103699;
}
