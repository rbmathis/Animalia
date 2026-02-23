namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Species: Oriolus tenuirostris
/// NCBI TaxId: 1200965
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oriolus_tenuirostris : Oriolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oriolus tenuirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oriolus_tenuirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1200965;
}
