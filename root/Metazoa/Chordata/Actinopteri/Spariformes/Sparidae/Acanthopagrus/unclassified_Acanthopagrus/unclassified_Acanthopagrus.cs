using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Acanthopagrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Acanthopagrus.unclassified_Acanthopagrus;

/// <summary>
/// Abstract class for unclassified Acanthopagrus (no rank).
/// NCBI TaxId: 2618481
/// </summary>
public abstract class unclassified_Acanthopagrus : Acanthopagrus, Iunclassified_Acanthopagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthopagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618481;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthopagrus";
}
