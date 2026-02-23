using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Eucinostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Eucinostomus.unclassified_Eucinostomus;

/// <summary>
/// Abstract class for unclassified Eucinostomus (no rank).
/// NCBI TaxId: 2620286
/// </summary>
public abstract class unclassified_Eucinostomus : Eucinostomus, Iunclassified_Eucinostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eucinostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620286;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eucinostomus";
}
