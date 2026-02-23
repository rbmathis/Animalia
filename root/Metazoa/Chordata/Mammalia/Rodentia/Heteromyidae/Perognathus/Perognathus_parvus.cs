namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Perognathus;

/// <summary>
/// Species: Perognathus parvus
/// NCBI TaxId: 38671
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perognathus_parvus : Perognathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perognathus parvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perognathus_parvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38671;
}
