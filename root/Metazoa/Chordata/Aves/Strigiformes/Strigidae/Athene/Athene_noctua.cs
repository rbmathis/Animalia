namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Athene;

/// <summary>
/// Species: Athene noctua
/// NCBI TaxId: 126797
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Athene_noctua : Athene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Athene noctua";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Athene_noctua";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126797;
}
