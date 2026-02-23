using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Astroblepidae.Astroblepus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Astroblepidae.Astroblepus.unclassified_Astroblepus;

/// <summary>
/// Abstract class for unclassified Astroblepus (no rank).
/// NCBI TaxId: 2602585
/// </summary>
public abstract class unclassified_Astroblepus : Astroblepus, Iunclassified_Astroblepus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astroblepus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602585;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astroblepus";
}
