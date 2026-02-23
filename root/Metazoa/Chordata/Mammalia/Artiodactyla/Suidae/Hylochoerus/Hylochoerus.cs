using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Hylochoerus;

/// <summary>
/// Abstract class for Hylochoerus (genus).
/// NCBI TaxId: 673353
/// </summary>
public abstract class Hylochoerus : Suidae, IHylochoerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylochoerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 673353;

    /// <inheritdoc />
    public virtual string GenusName => "Hylochoerus";

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
