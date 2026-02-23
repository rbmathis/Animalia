using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Antilocapridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Antilocapridae.Antilocapra;

/// <summary>
/// Abstract class for Antilocapra (genus).
/// NCBI TaxId: 9890
/// </summary>
public abstract class Antilocapra : Antilocapridae, IAntilocapra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antilocapra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9890;

    /// <inheritdoc />
    public virtual string GenusName => "Antilocapra";

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
