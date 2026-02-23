namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Vanellus;

/// <summary>
/// Species: Vanellus armatus
/// NCBI TaxId: 1630617
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vanellus_armatus : Vanellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vanellus armatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vanellus_armatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1630617;
}
