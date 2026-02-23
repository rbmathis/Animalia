namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tragopan;

/// <summary>
/// Species: Tragopan melanocephalus
/// NCBI TaxId: 128172
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tragopan_melanocephalus : Tragopan
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tragopan melanocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tragopan_melanocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 128172;
}
