namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dryocopus;

/// <summary>
/// Species: Dryocopus martius
/// NCBI TaxId: 187859
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dryocopus_martius : Dryocopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dryocopus martius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dryocopus_martius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 187859;
}
