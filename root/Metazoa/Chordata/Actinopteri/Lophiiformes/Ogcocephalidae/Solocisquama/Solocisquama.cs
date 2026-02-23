using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Solocisquama;

/// <summary>
/// Abstract class for Solocisquama (genus).
/// NCBI TaxId: 1592519
/// </summary>
public abstract class Solocisquama : Ogcocephalidae, ISolocisquama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solocisquama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1592519;

    /// <inheritdoc />
    public virtual string GenusName => "Solocisquama";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
