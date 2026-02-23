namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botryllus;

/// <summary>
/// Species: Botryllus primigenus
/// NCBI TaxId: 62810
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Botryllus_primigenus : Botryllus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Botryllus primigenus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Botryllus_primigenus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62810;
}
