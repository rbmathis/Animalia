namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Buceros;

/// <summary>
/// Species: Buceros rhinoceros
/// NCBI TaxId: 175835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Buceros_rhinoceros : Buceros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Buceros rhinoceros";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Buceros_rhinoceros";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175835;
}
