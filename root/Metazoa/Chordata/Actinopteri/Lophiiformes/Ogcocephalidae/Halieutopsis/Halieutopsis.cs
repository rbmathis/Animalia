using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halieutopsis;

/// <summary>
/// Abstract class for Halieutopsis (genus).
/// NCBI TaxId: 1592448
/// </summary>
public abstract class Halieutopsis : Ogcocephalidae, IHalieutopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halieutopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1592448;

    /// <inheritdoc />
    public virtual string GenusName => "Halieutopsis";

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
