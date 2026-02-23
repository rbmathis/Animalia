namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Gerrhosaurus;

/// <summary>
/// Species: Gerrhosaurus typicus
/// NCBI TaxId: 126622
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerrhosaurus_typicus : Gerrhosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerrhosaurus typicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerrhosaurus_typicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126622;
}
