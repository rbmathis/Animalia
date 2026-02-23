using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomus.unclassified_Catostomus;

/// <summary>
/// Abstract class for unclassified Catostomus (no rank).
/// NCBI TaxId: 2640481
/// </summary>
public abstract class unclassified_Catostomus : Catostomus, Iunclassified_Catostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Catostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640481;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Catostomus";
}
