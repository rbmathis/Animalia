namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Theristicus;

/// <summary>
/// Species: Theristicus caerulescens
/// NCBI TaxId: 1118847
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Theristicus_caerulescens : Theristicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Theristicus caerulescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Theristicus_caerulescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118847;
}
