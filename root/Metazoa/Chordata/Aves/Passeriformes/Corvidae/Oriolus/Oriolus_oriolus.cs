namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Species: Oriolus oriolus
/// NCBI TaxId: 181099
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oriolus_oriolus : Oriolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oriolus oriolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oriolus_oriolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 181099;
}
