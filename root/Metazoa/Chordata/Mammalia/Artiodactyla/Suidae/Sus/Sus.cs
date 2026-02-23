using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

/// <summary>
/// Abstract class for Sus (genus).
/// NCBI TaxId: 9822
/// </summary>
public abstract class Sus : Suidae, ISus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9822;

    /// <inheritdoc />
    public virtual string GenusName => "Sus";

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
