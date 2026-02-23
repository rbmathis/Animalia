using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Acanthostracion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Acanthostracion.unclassified_Acanthostracion;

/// <summary>
/// Abstract class for unclassified Acanthostracion (no rank).
/// NCBI TaxId: 2647997
/// </summary>
public abstract class unclassified_Acanthostracion : Acanthostracion, Iunclassified_Acanthostracion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthostracion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthostracion";
}
