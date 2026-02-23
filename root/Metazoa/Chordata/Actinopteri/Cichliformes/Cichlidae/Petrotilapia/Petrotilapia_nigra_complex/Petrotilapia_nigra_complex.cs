using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrotilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petrotilapia.Petrotilapia_nigra_complex;

/// <summary>
/// Abstract class for Petrotilapia nigra complex (no rank).
/// NCBI TaxId: 1905356
/// </summary>
public abstract class Petrotilapia_nigra_complex : Petrotilapia, IPetrotilapia_nigra_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrotilapia nigra complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1905356;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Petrotilapia_nigra_complex";
}
