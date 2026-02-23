using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Hippocamelus;

/// <summary>
/// Abstract class for Hippocamelus (genus).
/// NCBI TaxId: 371034
/// </summary>
public abstract class Hippocamelus : Cervidae, IHippocamelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippocamelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 371034;

    /// <inheritdoc />
    public virtual string GenusName => "Hippocamelus";

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
