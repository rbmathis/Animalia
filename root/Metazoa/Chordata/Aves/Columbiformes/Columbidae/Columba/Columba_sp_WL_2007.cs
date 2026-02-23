namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columba;

/// <summary>
/// Species: Columba sp. WL-2007
/// NCBI TaxId: 489119
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Columba_sp_WL_2007 : Columba
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Columba sp. WL-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Columba_sp_WL_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 489119;
}
