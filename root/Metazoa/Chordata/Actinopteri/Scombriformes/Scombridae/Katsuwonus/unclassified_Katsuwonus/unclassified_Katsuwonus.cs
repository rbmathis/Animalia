using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Katsuwonus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Katsuwonus.unclassified_Katsuwonus;

/// <summary>
/// Abstract class for unclassified Katsuwonus (no rank).
/// NCBI TaxId: 2734947
/// </summary>
public abstract class unclassified_Katsuwonus : Katsuwonus, Iunclassified_Katsuwonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Katsuwonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2734947;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Katsuwonus";
}
