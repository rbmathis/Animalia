using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Petrotyx;

/// <summary>
/// Abstract class for Petrotyx (genus).
/// NCBI TaxId: 94931
/// </summary>
public abstract class Petrotyx : Ophidiidae, IPetrotyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrotyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94931;

    /// <inheritdoc />
    public virtual string GenusName => "Petrotyx";

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
