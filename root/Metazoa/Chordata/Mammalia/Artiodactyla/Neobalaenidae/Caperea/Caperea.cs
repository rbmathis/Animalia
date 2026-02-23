using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Neobalaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Neobalaenidae.Caperea;

/// <summary>
/// Abstract class for Caperea (genus).
/// NCBI TaxId: 27603
/// </summary>
public abstract class Caperea : Neobalaenidae, ICaperea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caperea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27603;

    /// <inheritdoc />
    public virtual string GenusName => "Caperea";

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
