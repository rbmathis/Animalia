namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Troglodytes;

/// <summary>
/// Species: Troglodytes sissonii
/// NCBI TaxId: 3050771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Troglodytes_sissonii : Troglodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Troglodytes sissonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Troglodytes_sissonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3050771;
}
