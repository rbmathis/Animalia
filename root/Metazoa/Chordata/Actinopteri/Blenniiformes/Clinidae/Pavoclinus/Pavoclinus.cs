using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Pavoclinus;

/// <summary>
/// Abstract class for Pavoclinus (genus).
/// NCBI TaxId: 879880
/// </summary>
public abstract class Pavoclinus : Clinidae, IPavoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pavoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879880;

    /// <inheritdoc />
    public virtual string GenusName => "Pavoclinus";

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
