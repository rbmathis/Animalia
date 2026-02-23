using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Indoreonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Indoreonectes.unclassified_Indoreonectes;

/// <summary>
/// Abstract class for unclassified Indoreonectes (no rank).
/// NCBI TaxId: 2645213
/// </summary>
public abstract class unclassified_Indoreonectes : Indoreonectes, Iunclassified_Indoreonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Indoreonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645213;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Indoreonectes";
}
