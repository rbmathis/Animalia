namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Vanellus;

/// <summary>
/// Species: Vanellus vanellus
/// NCBI TaxId: 100859
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vanellus_vanellus : Vanellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vanellus vanellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vanellus_vanellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100859;
}
