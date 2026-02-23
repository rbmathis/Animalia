using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Leontocebus;

/// <summary>
/// Abstract class for Leontocebus (genus).
/// NCBI TaxId: 2681187
/// </summary>
public abstract class Leontocebus : Cebidae, ILeontocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leontocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2681187;

    /// <inheritdoc />
    public virtual string GenusName => "Leontocebus";

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
