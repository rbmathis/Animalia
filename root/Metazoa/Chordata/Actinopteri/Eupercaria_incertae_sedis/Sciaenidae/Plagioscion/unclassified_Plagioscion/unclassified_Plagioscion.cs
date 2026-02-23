using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Plagioscion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Plagioscion.unclassified_Plagioscion;

/// <summary>
/// Abstract class for unclassified Plagioscion (no rank).
/// NCBI TaxId: 2636998
/// </summary>
public abstract class unclassified_Plagioscion : Plagioscion, Iunclassified_Plagioscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plagioscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636998;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plagioscion";
}
