namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Eudynamys;

/// <summary>
/// Species: Eudynamys scolopaceus
/// NCBI TaxId: 8945
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eudynamys_scolopaceus : Eudynamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eudynamys scolopaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eudynamys_scolopaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8945;
}
