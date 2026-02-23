using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Ornithorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Ornithorhynchidae.Ornithorhynchus;

/// <summary>
/// Abstract class for Ornithorhynchus (genus).
/// NCBI TaxId: 9257
/// </summary>
public abstract class Ornithorhynchus : Ornithorhynchidae, IOrnithorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ornithorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9257;

    /// <inheritdoc />
    public virtual string GenusName => "Ornithorhynchus";

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
