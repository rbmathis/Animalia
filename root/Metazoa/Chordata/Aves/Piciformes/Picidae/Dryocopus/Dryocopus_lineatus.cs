namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryocopus;

/// <summary>
/// Species: Dryocopus lineatus
/// NCBI TaxId: 121135
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dryocopus_lineatus : Dryocopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dryocopus lineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dryocopus_lineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121135;
}
