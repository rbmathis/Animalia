namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Phegornis;

/// <summary>
/// Species: Phegornis mitchellii
/// NCBI TaxId: 227179
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phegornis_mitchellii : Phegornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phegornis mitchellii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phegornis_mitchellii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227179;
}
