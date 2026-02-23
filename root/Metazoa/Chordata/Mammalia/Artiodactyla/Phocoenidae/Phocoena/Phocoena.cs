using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Phocoena;

/// <summary>
/// Abstract class for Phocoena (genus).
/// NCBI TaxId: 9741
/// </summary>
public abstract class Phocoena : Phocoenidae, IPhocoena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phocoena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9741;

    /// <inheritdoc />
    public virtual string GenusName => "Phocoena";

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
