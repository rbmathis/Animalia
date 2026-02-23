namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Luperosaurus;

/// <summary>
/// Species: Luperosaurus sp. CDS-2012
/// NCBI TaxId: 1183244
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Luperosaurus_sp_CDS_2012 : Luperosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Luperosaurus sp. CDS-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Luperosaurus_sp_CDS_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1183244;
}
