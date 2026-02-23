using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Glaucostegidae.Glaucostegus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Glaucostegidae.Glaucostegus.unclassified_Glaucostegus;

/// <summary>
/// Abstract class for unclassified Glaucostegus (no rank).
/// NCBI TaxId: 2626911
/// </summary>
public abstract class unclassified_Glaucostegus : Glaucostegus, Iunclassified_Glaucostegus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glaucostegus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626911;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glaucostegus";
}
