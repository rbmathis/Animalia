namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

/// <summary>
/// Species: Charadrius placidus
/// NCBI TaxId: 1630616
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Charadrius_placidus : Charadrius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Charadrius placidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Charadrius_placidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1630616;
}
