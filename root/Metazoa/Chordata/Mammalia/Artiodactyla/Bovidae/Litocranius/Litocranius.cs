using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Litocranius;

/// <summary>
/// Abstract class for Litocranius (genus).
/// NCBI TaxId: 69310
/// </summary>
public abstract class Litocranius : Bovidae, ILitocranius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Litocranius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69310;

    /// <inheritdoc />
    public virtual string GenusName => "Litocranius";

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
