using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Atractoscion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Atractoscion.unclassified_Atractoscion;

/// <summary>
/// Abstract class for unclassified Atractoscion (no rank).
/// NCBI TaxId: 2645257
/// </summary>
public abstract class unclassified_Atractoscion : Atractoscion, Iunclassified_Atractoscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atractoscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645257;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atractoscion";
}
