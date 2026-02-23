using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Petroscirtes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Petroscirtes.unclassified_Petroscirtes;

/// <summary>
/// Abstract class for unclassified Petroscirtes (no rank).
/// NCBI TaxId: 2629132
/// </summary>
public abstract class unclassified_Petroscirtes : Petroscirtes, Iunclassified_Petroscirtes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petroscirtes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629132;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petroscirtes";
}
