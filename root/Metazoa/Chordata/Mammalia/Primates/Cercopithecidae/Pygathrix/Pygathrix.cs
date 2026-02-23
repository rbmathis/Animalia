using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Pygathrix;

/// <summary>
/// Abstract class for Pygathrix (genus).
/// NCBI TaxId: 54132
/// </summary>
public abstract class Pygathrix : Cercopithecidae, IPygathrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygathrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54132;

    /// <inheritdoc />
    public virtual string GenusName => "Pygathrix";

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
