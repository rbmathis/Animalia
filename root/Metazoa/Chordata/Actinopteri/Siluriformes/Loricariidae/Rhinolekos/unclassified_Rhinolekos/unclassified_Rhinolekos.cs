using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhinolekos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhinolekos.unclassified_Rhinolekos;

/// <summary>
/// Abstract class for unclassified Rhinolekos (no rank).
/// NCBI TaxId: 2631280
/// </summary>
public abstract class unclassified_Rhinolekos : Rhinolekos, Iunclassified_Rhinolekos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinolekos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631280;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinolekos";
}
