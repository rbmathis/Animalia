using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Pardachirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Pardachirus.unclassified_Pardachirus;

/// <summary>
/// Abstract class for unclassified Pardachirus (no rank).
/// NCBI TaxId: 2618807
/// </summary>
public abstract class unclassified_Pardachirus : Pardachirus, Iunclassified_Pardachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pardachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618807;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pardachirus";
}
