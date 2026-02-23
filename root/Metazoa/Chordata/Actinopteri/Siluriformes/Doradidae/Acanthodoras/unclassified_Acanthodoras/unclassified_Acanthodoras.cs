using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Acanthodoras;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Acanthodoras.unclassified_Acanthodoras;

/// <summary>
/// Abstract class for unclassified Acanthodoras (no rank).
/// NCBI TaxId: 2635313
/// </summary>
public abstract class unclassified_Acanthodoras : Acanthodoras, Iunclassified_Acanthodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635313;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthodoras";
}
