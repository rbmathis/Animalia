using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Lophocebus;

/// <summary>
/// Abstract class for Lophocebus (genus).
/// NCBI TaxId: 75565
/// </summary>
public abstract class Lophocebus : Cercopithecidae, ILophocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75565;

    /// <inheritdoc />
    public virtual string GenusName => "Lophocebus";

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
