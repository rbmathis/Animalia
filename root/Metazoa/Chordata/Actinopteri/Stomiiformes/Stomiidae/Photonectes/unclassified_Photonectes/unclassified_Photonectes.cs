using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Photonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Photonectes.unclassified_Photonectes;

/// <summary>
/// Abstract class for unclassified Photonectes (no rank).
/// NCBI TaxId: 2638849
/// </summary>
public abstract class unclassified_Photonectes : Photonectes, Iunclassified_Photonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Photonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638849;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Photonectes";
}
