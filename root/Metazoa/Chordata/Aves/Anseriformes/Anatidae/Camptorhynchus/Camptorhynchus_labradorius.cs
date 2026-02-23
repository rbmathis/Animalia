namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Camptorhynchus;

/// <summary>
/// Species: Camptorhynchus labradorius
/// NCBI TaxId: 399386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camptorhynchus_labradorius : Camptorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camptorhynchus labradorius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camptorhynchus_labradorius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 399386;
}
