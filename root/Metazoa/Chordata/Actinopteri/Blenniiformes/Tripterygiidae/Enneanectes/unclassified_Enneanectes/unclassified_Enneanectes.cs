using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Enneanectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Enneanectes.unclassified_Enneanectes;

/// <summary>
/// Abstract class for unclassified Enneanectes (no rank).
/// NCBI TaxId: 2647610
/// </summary>
public abstract class unclassified_Enneanectes : Enneanectes, Iunclassified_Enneanectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Enneanectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647610;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Enneanectes";
}
