using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Erythrocebus;

/// <summary>
/// Abstract class for Erythrocebus (genus).
/// NCBI TaxId: 9537
/// </summary>
public abstract class Erythrocebus : Cercopithecidae, IErythrocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erythrocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9537;

    /// <inheritdoc />
    public virtual string GenusName => "Erythrocebus";

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
