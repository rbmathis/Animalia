namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heros;

/// <summary>
/// Species: Heros sp. OR-2006
/// NCBI TaxId: 407118
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heros_sp_OR_2006 : Heros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heros sp. OR-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heros_sp_OR_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 407118;
}
