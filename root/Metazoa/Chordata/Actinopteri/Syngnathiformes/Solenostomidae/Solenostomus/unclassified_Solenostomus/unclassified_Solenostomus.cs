using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Solenostomidae.Solenostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Solenostomidae.Solenostomus.unclassified_Solenostomus;

/// <summary>
/// Abstract class for unclassified Solenostomus (no rank).
/// NCBI TaxId: 2624688
/// </summary>
public abstract class unclassified_Solenostomus : Solenostomus, Iunclassified_Solenostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Solenostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624688;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Solenostomus";
}
