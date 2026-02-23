using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Paradipus;

/// <summary>
/// Abstract class for Paradipus (genus).
/// NCBI TaxId: 1247381
/// </summary>
public abstract class Paradipus : Dipodidae, IParadipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1247381;

    /// <inheritdoc />
    public virtual string GenusName => "Paradipus";

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
