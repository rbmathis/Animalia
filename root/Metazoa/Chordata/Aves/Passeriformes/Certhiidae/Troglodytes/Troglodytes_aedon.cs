namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Troglodytes;

/// <summary>
/// Species: Troglodytes aedon
/// NCBI TaxId: 58211
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Troglodytes_aedon : Troglodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Troglodytes aedon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Troglodytes_aedon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 58211;
}
