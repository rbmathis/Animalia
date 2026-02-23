namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Coracias;

/// <summary>
/// Species: Coracias temminckii
/// NCBI TaxId: 2502803
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracias_temminckii : Coracias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracias temminckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracias_temminckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2502803;
}
