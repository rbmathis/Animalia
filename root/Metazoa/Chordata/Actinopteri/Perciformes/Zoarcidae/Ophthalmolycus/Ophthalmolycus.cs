using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Ophthalmolycus;

/// <summary>
/// Abstract class for Ophthalmolycus (genus).
/// NCBI TaxId: 948066
/// </summary>
public abstract class Ophthalmolycus : Zoarcidae, IOphthalmolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophthalmolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948066;

    /// <inheritdoc />
    public virtual string GenusName => "Ophthalmolycus";

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
