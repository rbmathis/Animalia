namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pachytriton;

/// <summary>
/// Species: Pachytriton archospotus
/// NCBI TaxId: 702380
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachytriton_archospotus : Pachytriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachytriton archospotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachytriton_archospotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 702380;
}
