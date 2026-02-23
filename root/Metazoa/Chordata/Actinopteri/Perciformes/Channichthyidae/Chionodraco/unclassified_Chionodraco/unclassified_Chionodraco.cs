using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chionodraco;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chionodraco.unclassified_Chionodraco;

/// <summary>
/// Abstract class for unclassified Chionodraco (no rank).
/// NCBI TaxId: 3096703
/// </summary>
public abstract class unclassified_Chionodraco : Chionodraco, Iunclassified_Chionodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chionodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3096703;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chionodraco";
}
