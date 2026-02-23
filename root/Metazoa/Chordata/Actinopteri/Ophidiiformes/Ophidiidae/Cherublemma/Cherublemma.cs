using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Cherublemma;

/// <summary>
/// Abstract class for Cherublemma (genus).
/// NCBI TaxId: 2048772
/// </summary>
public abstract class Cherublemma : Ophidiidae, ICherublemma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cherublemma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2048772;

    /// <inheritdoc />
    public virtual string GenusName => "Cherublemma";

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
