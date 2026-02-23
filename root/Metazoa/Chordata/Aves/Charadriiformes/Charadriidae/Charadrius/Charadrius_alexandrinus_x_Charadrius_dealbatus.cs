namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Charadrius;

/// <summary>
/// Species: Charadrius alexandrinus x Charadrius dealbatus
/// NCBI TaxId: 2697428
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Charadrius_alexandrinus_x_Charadrius_dealbatus : Charadrius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Charadrius alexandrinus x Charadrius dealbatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Charadrius_alexandrinus_x_Charadrius_dealbatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2697428;
}
