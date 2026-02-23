namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Species: Oriolus albiloris
/// NCBI TaxId: 890048
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oriolus_albiloris : Oriolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oriolus albiloris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oriolus_albiloris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 890048;
}
