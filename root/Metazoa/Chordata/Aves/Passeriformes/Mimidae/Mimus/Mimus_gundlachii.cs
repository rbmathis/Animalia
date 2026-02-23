namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Mimus;

/// <summary>
/// Species: Mimus gundlachii
/// NCBI TaxId: 111997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mimus_gundlachii : Mimus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mimus gundlachii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mimus_gundlachii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111997;
}
