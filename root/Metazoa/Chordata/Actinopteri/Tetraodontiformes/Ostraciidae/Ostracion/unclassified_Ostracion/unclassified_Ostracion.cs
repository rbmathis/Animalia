using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Ostracion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Ostracion.unclassified_Ostracion;

/// <summary>
/// Abstract class for unclassified Ostracion (no rank).
/// NCBI TaxId: 2644641
/// </summary>
public abstract class unclassified_Ostracion : Ostracion, Iunclassified_Ostracion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ostracion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644641;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ostracion";
}
