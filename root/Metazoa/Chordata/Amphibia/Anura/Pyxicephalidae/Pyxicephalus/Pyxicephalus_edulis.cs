namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Pyxicephalus;

/// <summary>
/// Species: Pyxicephalus edulis
/// NCBI TaxId: 333692
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pyxicephalus_edulis : Pyxicephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pyxicephalus edulis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pyxicephalus_edulis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 333692;
}
