using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Papiliolebias;

/// <summary>
/// Abstract class for Papiliolebias (genus).
/// NCBI TaxId: 135292
/// </summary>
public abstract class Papiliolebias : Rivulidae, IPapiliolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papiliolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135292;

    /// <inheritdoc />
    public virtual string GenusName => "Papiliolebias";

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
