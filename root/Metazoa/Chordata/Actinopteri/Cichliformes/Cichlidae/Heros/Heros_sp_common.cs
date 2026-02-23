namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heros;

/// <summary>
/// Species: Heros sp. 'common'
/// NCBI TaxId: 762771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heros_sp_common : Heros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heros sp. 'common'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heros_sp_common";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 762771;
}
