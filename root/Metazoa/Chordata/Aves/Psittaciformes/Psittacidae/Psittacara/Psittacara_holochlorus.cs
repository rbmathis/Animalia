namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara holochlorus
/// NCBI TaxId: 867390
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_holochlorus : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara holochlorus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_holochlorus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867390;
}
