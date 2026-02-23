using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oryx;

/// <summary>
/// Abstract class for Oryx (genus).
/// NCBI TaxId: 9957
/// </summary>
public abstract class Oryx : Bovidae, IOryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9957;

    /// <inheritdoc />
    public virtual string GenusName => "Oryx";

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
