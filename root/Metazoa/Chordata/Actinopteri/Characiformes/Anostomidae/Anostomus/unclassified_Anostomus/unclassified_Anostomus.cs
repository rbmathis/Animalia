using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Anostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Anostomus.unclassified_Anostomus;

/// <summary>
/// Abstract class for unclassified Anostomus (no rank).
/// NCBI TaxId: 3101808
/// </summary>
public abstract class unclassified_Anostomus : Anostomus, Iunclassified_Anostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101808;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anostomus";
}
