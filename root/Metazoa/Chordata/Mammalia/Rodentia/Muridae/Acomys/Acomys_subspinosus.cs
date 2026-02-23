namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

/// <summary>
/// Species: Acomys subspinosus
/// NCBI TaxId: 81631
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acomys_subspinosus : Acomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acomys subspinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acomys_subspinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81631;
}
