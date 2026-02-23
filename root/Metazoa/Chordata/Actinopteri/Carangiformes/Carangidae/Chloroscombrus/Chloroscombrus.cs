using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Chloroscombrus;

/// <summary>
/// Abstract class for Chloroscombrus (genus).
/// NCBI TaxId: 173328
/// </summary>
public abstract class Chloroscombrus : Carangidae, IChloroscombrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloroscombrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173328;

    /// <inheritdoc />
    public virtual string GenusName => "Chloroscombrus";

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
