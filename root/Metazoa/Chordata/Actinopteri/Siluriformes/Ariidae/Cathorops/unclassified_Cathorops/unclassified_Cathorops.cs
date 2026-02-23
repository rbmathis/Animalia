using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cathorops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cathorops.unclassified_Cathorops;

/// <summary>
/// Abstract class for unclassified Cathorops (no rank).
/// NCBI TaxId: 2685225
/// </summary>
public abstract class unclassified_Cathorops : Cathorops, Iunclassified_Cathorops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cathorops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685225;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cathorops";
}
