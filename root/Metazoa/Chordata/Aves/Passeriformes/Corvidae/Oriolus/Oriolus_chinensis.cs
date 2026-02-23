namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Species: Oriolus chinensis
/// NCBI TaxId: 409288
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oriolus_chinensis : Oriolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oriolus chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oriolus_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 409288;
}
