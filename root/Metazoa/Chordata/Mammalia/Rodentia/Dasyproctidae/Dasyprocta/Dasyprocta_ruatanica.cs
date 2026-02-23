namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta;

/// <summary>
/// Species: Dasyprocta ruatanica
/// NCBI TaxId: 3082515
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyprocta_ruatanica : Dasyprocta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyprocta ruatanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyprocta_ruatanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3082515;
}
