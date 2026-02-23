namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anser;

/// <summary>
/// Species: Anser brachyrhynchus
/// NCBI TaxId: 132585
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anser_brachyrhynchus : Anser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anser brachyrhynchus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anser_brachyrhynchus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 132585;
}
