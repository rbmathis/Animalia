namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Belomys;

/// <summary>
/// Species: Belomys pearsonii
/// NCBI TaxId: 100949
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Belomys_pearsonii : Belomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Belomys pearsonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Belomys_pearsonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100949;
}
