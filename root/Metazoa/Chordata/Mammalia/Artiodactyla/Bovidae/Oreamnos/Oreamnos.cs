using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oreamnos;

/// <summary>
/// Abstract class for Oreamnos (genus).
/// NCBI TaxId: 34872
/// </summary>
public abstract class Oreamnos : Bovidae, IOreamnos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreamnos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34872;

    /// <inheritdoc />
    public virtual string GenusName => "Oreamnos";

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
