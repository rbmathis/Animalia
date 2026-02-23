namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Troglodytes;

/// <summary>
/// Species: Troglodytes pacificus
/// NCBI TaxId: 1392764
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Troglodytes_pacificus : Troglodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Troglodytes pacificus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Troglodytes_pacificus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1392764;
}
