using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Idiacanthus;

/// <summary>
/// Abstract class for Idiacanthus (genus).
/// NCBI TaxId: 314240
/// </summary>
public abstract class Idiacanthus : Stomiidae, IIdiacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idiacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 314240;

    /// <inheritdoc />
    public virtual string GenusName => "Idiacanthus";

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
