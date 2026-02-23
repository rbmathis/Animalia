namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botryllus;

/// <summary>
/// Species: Botryllus arenaceus
/// NCBI TaxId: 1775710
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Botryllus_arenaceus : Botryllus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Botryllus arenaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Botryllus_arenaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1775710;
}
