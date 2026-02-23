namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Meriones;

/// <summary>
/// Species: Meriones rex
/// NCBI TaxId: 298885
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Meriones_rex : Meriones
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Meriones rex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Meriones_rex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 298885;
}
