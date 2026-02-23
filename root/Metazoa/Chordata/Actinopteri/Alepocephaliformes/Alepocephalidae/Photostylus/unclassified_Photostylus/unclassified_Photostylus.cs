using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Photostylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Photostylus.unclassified_Photostylus;

/// <summary>
/// Abstract class for unclassified Photostylus (no rank).
/// NCBI TaxId: 2643112
/// </summary>
public abstract class unclassified_Photostylus : Photostylus, Iunclassified_Photostylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Photostylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643112;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Photostylus";
}
