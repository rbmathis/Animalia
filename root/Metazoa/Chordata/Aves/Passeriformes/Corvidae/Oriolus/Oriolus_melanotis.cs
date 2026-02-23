namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Species: Oriolus melanotis
/// NCBI TaxId: 890105
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oriolus_melanotis : Oriolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oriolus melanotis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oriolus_melanotis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 890105;
}
