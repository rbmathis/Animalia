using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Allochrocebus;

/// <summary>
/// Abstract class for Allochrocebus (genus).
/// NCBI TaxId: 2059839
/// </summary>
public abstract class Allochrocebus : Cercopithecidae, IAllochrocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allochrocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2059839;

    /// <inheritdoc />
    public virtual string GenusName => "Allochrocebus";

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
