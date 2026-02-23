namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta;

/// <summary>
/// Species: Dasyprocta kalinowski
/// NCBI TaxId: 3082514
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyprocta_kalinowski : Dasyprocta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyprocta kalinowski";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyprocta_kalinowski";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3082514;
}
