namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Ixos;

/// <summary>
/// Species: Ixos leucogrammicus
/// NCBI TaxId: 3150023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ixos_leucogrammicus : Ixos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ixos leucogrammicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ixos_leucogrammicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150023;
}
