using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Chelidonichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Chelidonichthys.unclassified_Chelidonichthys;

/// <summary>
/// Abstract class for unclassified Chelidonichthys (no rank).
/// NCBI TaxId: 2637343
/// </summary>
public abstract class unclassified_Chelidonichthys : Chelidonichthys, Iunclassified_Chelidonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chelidonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637343;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chelidonichthys";
}
