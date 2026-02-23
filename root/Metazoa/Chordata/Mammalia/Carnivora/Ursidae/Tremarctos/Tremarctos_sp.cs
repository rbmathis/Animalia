namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Tremarctos;

/// <summary>
/// Species: Tremarctos sp.
/// NCBI TaxId: 30556
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tremarctos_sp : Tremarctos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tremarctos sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tremarctos_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30556;
}
