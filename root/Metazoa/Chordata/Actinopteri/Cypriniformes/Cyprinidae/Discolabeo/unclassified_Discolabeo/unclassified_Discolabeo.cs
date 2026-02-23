using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discolabeo;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discolabeo.unclassified_Discolabeo;

/// <summary>
/// Abstract class for unclassified Discolabeo (no rank).
/// NCBI TaxId: 2646564
/// </summary>
public abstract class unclassified_Discolabeo : Discolabeo, Iunclassified_Discolabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Discolabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646564;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Discolabeo";
}
