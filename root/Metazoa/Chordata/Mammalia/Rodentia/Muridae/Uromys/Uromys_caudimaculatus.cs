namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uromys;

/// <summary>
/// Species: Uromys caudimaculatus
/// NCBI TaxId: 36800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uromys_caudimaculatus : Uromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uromys caudimaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uromys_caudimaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36800;
}
