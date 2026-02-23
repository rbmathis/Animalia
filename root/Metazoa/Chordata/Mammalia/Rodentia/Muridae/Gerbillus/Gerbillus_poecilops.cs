namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbillus;

/// <summary>
/// Species: Gerbillus poecilops
/// NCBI TaxId: 1194295
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbillus_poecilops : Gerbillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbillus poecilops";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbillus_poecilops";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1194295;
}
