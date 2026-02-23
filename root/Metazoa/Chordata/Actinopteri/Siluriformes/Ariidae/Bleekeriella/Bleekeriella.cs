using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Bleekeriella;

/// <summary>
/// Abstract class for Bleekeriella (genus).
/// NCBI TaxId: 3363394
/// </summary>
public abstract class Bleekeriella : Ariidae, IBleekeriella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bleekeriella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363394;

    /// <inheritdoc />
    public virtual string GenusName => "Bleekeriella";

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
