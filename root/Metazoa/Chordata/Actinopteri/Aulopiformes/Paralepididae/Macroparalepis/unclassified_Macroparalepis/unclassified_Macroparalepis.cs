using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Macroparalepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Macroparalepis.unclassified_Macroparalepis;

/// <summary>
/// Abstract class for unclassified Macroparalepis (no rank).
/// NCBI TaxId: 3435969
/// </summary>
public abstract class unclassified_Macroparalepis : Macroparalepis, Iunclassified_Macroparalepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macroparalepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3435969;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macroparalepis";
}
