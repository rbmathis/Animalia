namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Certhia;

/// <summary>
/// Species: Certhia americana
/// NCBI TaxId: 186443
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Certhia_americana : Certhia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Certhia americana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Certhia_americana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 186443;
}
