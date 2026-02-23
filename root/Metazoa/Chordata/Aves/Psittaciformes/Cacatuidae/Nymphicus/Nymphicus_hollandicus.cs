namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Nymphicus;

/// <summary>
/// Species: Nymphicus hollandicus
/// NCBI TaxId: 13180
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nymphicus_hollandicus : Nymphicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nymphicus hollandicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nymphicus_hollandicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13180;
}
