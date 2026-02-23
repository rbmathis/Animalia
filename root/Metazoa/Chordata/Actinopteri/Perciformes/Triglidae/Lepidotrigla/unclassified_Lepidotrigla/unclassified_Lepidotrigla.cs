using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Lepidotrigla;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Lepidotrigla.unclassified_Lepidotrigla;

/// <summary>
/// Abstract class for unclassified Lepidotrigla (no rank).
/// NCBI TaxId: 2632543
/// </summary>
public abstract class unclassified_Lepidotrigla : Lepidotrigla, Iunclassified_Lepidotrigla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidotrigla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632543;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidotrigla";
}
