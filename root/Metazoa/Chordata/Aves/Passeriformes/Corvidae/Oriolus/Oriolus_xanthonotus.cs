namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Species: Oriolus xanthonotus
/// NCBI TaxId: 98140
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oriolus_xanthonotus : Oriolus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oriolus xanthonotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oriolus_xanthonotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 98140;
}
