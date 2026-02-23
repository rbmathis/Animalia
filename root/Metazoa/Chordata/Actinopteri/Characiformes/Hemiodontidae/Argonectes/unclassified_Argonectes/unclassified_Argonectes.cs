using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Argonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Argonectes.unclassified_Argonectes;

/// <summary>
/// Abstract class for unclassified Argonectes (no rank).
/// NCBI TaxId: 3101812
/// </summary>
public abstract class unclassified_Argonectes : Argonectes, Iunclassified_Argonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101812;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argonectes";
}
