using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Malthopsis;

/// <summary>
/// Abstract class for Malthopsis (genus).
/// NCBI TaxId: 215332
/// </summary>
public abstract class Malthopsis : Ogcocephalidae, IMalthopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malthopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215332;

    /// <inheritdoc />
    public virtual string GenusName => "Malthopsis";

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
