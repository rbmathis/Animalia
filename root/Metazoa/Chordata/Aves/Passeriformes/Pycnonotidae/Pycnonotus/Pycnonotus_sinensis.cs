namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Pycnonotus;

/// <summary>
/// Species: Pycnonotus sinensis
/// NCBI TaxId: 125283
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pycnonotus_sinensis : Pycnonotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pycnonotus sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pycnonotus_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 125283;
}
