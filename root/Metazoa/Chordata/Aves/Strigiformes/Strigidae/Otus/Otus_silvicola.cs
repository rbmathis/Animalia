namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus silvicola
/// NCBI TaxId: 3045879
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_silvicola : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus silvicola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_silvicola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045879;
}
