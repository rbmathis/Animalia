using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Kurtidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Kurtidae.Kurtus;

/// <summary>
/// Abstract class for Kurtus (genus).
/// NCBI TaxId: 215394
/// </summary>
public abstract class Kurtus : Kurtidae, IKurtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kurtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215394;

    /// <inheritdoc />
    public virtual string GenusName => "Kurtus";

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
