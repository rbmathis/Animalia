using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Pungitius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Pungitius.unclassified_Pungitius;

/// <summary>
/// Abstract class for unclassified Pungitius (no rank).
/// NCBI TaxId: 2643537
/// </summary>
public abstract class unclassified_Pungitius : Pungitius, Iunclassified_Pungitius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pungitius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643537;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pungitius";
}
