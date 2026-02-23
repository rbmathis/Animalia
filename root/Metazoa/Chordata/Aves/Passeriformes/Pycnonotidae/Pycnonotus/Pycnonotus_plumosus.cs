namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Pycnonotus;

/// <summary>
/// Species: Pycnonotus plumosus
/// NCBI TaxId: 270475
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pycnonotus_plumosus : Pycnonotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pycnonotus plumosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pycnonotus_plumosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 270475;
}
