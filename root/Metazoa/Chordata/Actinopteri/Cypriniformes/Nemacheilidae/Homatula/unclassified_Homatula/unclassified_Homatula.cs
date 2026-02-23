using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Homatula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Homatula.unclassified_Homatula;

/// <summary>
/// Abstract class for unclassified Homatula (no rank).
/// NCBI TaxId: 2677390
/// </summary>
public abstract class unclassified_Homatula : Homatula, Iunclassified_Homatula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Homatula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677390;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Homatula";
}
