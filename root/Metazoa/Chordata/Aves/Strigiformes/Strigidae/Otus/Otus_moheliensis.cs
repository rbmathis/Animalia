namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus moheliensis
/// NCBI TaxId: 543869
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_moheliensis : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus moheliensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_moheliensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 543869;
}
