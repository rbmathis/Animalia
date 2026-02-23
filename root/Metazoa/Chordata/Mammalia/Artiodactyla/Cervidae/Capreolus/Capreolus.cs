using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Capreolus;

/// <summary>
/// Abstract class for Capreolus (genus).
/// NCBI TaxId: 9857
/// </summary>
public abstract class Capreolus : Cervidae, ICapreolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Capreolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9857;

    /// <inheritdoc />
    public virtual string GenusName => "Capreolus";

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
