using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Cirripectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Cirripectes.unclassified_Cirripectes;

/// <summary>
/// Abstract class for unclassified Cirripectes (no rank).
/// NCBI TaxId: 2626303
/// </summary>
public abstract class unclassified_Cirripectes : Cirripectes, Iunclassified_Cirripectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirripectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626303;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirripectes";
}
