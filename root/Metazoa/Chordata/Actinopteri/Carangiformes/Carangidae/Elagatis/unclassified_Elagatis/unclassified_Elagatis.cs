using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Elagatis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Elagatis.unclassified_Elagatis;

/// <summary>
/// Abstract class for unclassified Elagatis (no rank).
/// NCBI TaxId: 2626398
/// </summary>
public abstract class unclassified_Elagatis : Elagatis, Iunclassified_Elagatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elagatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626398;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elagatis";
}
