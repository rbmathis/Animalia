using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae.Hyemoschus;

/// <summary>
/// Abstract class for Hyemoschus (genus).
/// NCBI TaxId: 666914
/// </summary>
public abstract class Hyemoschus : Tragulidae, IHyemoschus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyemoschus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666914;

    /// <inheritdoc />
    public virtual string GenusName => "Hyemoschus";

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
