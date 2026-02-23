using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hoplichthyidae.Hoplichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hoplichthyidae.Hoplichthys.unclassified_Hoplichthys;

/// <summary>
/// Abstract class for unclassified Hoplichthys (no rank).
/// NCBI TaxId: 2898407
/// </summary>
public abstract class unclassified_Hoplichthys : Hoplichthys, Iunclassified_Hoplichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2898407;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplichthys";
}
