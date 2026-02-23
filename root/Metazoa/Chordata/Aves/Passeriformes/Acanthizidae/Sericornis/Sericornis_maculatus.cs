namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Sericornis;

/// <summary>
/// Species: Sericornis maculatus
/// NCBI TaxId: 2480085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sericornis_maculatus : Sericornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sericornis maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sericornis_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2480085;
}
