using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Cirrhitichthys.unclassified_Cirrhitichthys;

/// <summary>
/// Abstract class for unclassified Cirrhitichthys (no rank).
/// NCBI TaxId: 2819346
/// </summary>
public abstract class unclassified_Cirrhitichthys : Cirrhitichthys, Iunclassified_Cirrhitichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrhitichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrhitichthys";
}
