namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenosauridae.Xenosaurus;

/// <summary>
/// Species: Xenosaurus sp. DDH-2003
/// NCBI TaxId: 227092
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenosaurus_sp_DDH_2003 : Xenosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenosaurus sp. DDH-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenosaurus_sp_DDH_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227092;
}
