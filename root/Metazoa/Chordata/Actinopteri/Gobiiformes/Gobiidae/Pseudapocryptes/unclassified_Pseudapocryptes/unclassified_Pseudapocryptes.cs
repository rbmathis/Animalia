using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudapocryptes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudapocryptes.unclassified_Pseudapocryptes;

/// <summary>
/// Abstract class for unclassified Pseudapocryptes (no rank).
/// NCBI TaxId: 2622423
/// </summary>
public abstract class unclassified_Pseudapocryptes : Pseudapocryptes, Iunclassified_Pseudapocryptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudapocryptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622423;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudapocryptes";
}
