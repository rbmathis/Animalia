using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Leucocephalophus;

/// <summary>
/// Abstract class for Leucocephalophus (genus).
/// NCBI TaxId: 3033998
/// </summary>
public abstract class Leucocephalophus : Bovidae, ILeucocephalophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucocephalophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3033998;

    /// <inheritdoc />
    public virtual string GenusName => "Leucocephalophus";

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
