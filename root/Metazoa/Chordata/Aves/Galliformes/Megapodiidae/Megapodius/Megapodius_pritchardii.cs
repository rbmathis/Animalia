namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Megapodius;

/// <summary>
/// Species: Megapodius pritchardii
/// NCBI TaxId: 177169
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megapodius_pritchardii : Megapodius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megapodius pritchardii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megapodius_pritchardii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 177169;
}
