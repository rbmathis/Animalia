using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rungwecebus;

/// <summary>
/// Abstract class for Rungwecebus (genus).
/// NCBI TaxId: 371038
/// </summary>
public abstract class Rungwecebus : Cercopithecidae, IRungwecebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rungwecebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 371038;

    /// <inheritdoc />
    public virtual string GenusName => "Rungwecebus";

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
