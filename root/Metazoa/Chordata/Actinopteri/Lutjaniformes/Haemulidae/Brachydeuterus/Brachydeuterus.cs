using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Brachydeuterus;

/// <summary>
/// Abstract class for Brachydeuterus (genus).
/// NCBI TaxId: 490310
/// </summary>
public abstract class Brachydeuterus : Haemulidae, IBrachydeuterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachydeuterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490310;

    /// <inheritdoc />
    public virtual string GenusName => "Brachydeuterus";

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
