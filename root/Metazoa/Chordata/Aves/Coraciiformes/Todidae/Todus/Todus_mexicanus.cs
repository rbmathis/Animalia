namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Todidae.Todus;

/// <summary>
/// Species: Todus mexicanus
/// NCBI TaxId: 135184
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Todus_mexicanus : Todus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Todus mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Todus_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 135184;
}
