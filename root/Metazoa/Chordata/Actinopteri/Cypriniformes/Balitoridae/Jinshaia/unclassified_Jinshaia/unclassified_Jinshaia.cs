using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Jinshaia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Jinshaia.unclassified_Jinshaia;

/// <summary>
/// Abstract class for unclassified Jinshaia (no rank).
/// NCBI TaxId: 3444396
/// </summary>
public abstract class unclassified_Jinshaia : Jinshaia, Iunclassified_Jinshaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Jinshaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444396;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Jinshaia";
}
