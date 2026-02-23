using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Bascanichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Bascanichthys.unclassified_Bascanichthys;

/// <summary>
/// Abstract class for unclassified Bascanichthys (no rank).
/// NCBI TaxId: 2626997
/// </summary>
public abstract class unclassified_Bascanichthys : Bascanichthys, Iunclassified_Bascanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bascanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bascanichthys";
}
