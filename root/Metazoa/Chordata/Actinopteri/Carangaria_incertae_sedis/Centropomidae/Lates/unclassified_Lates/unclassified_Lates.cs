using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Lates;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Lates.unclassified_Lates;

/// <summary>
/// Abstract class for unclassified Lates (no rank).
/// NCBI TaxId: 2638613
/// </summary>
public abstract class unclassified_Lates : Lates, Iunclassified_Lates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638613;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lates";
}
