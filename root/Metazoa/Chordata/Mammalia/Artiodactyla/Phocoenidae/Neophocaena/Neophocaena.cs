using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Neophocaena;

/// <summary>
/// Abstract class for Neophocaena (genus).
/// NCBI TaxId: 34891
/// </summary>
public abstract class Neophocaena : Phocoenidae, INeophocaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neophocaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34891;

    /// <inheritdoc />
    public virtual string GenusName => "Neophocaena";

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
