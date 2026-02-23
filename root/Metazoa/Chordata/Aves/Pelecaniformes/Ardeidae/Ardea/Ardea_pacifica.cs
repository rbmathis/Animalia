namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Ardea;

/// <summary>
/// Species: Ardea pacifica
/// NCBI TaxId: 585465
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ardea_pacifica : Ardea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ardea pacifica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ardea_pacifica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 585465;
}
