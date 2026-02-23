using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Clinus;

/// <summary>
/// Abstract class for Clinus (genus).
/// NCBI TaxId: 387439
/// </summary>
public abstract class Clinus : Clinidae, IClinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 387439;

    /// <inheritdoc />
    public virtual string GenusName => "Clinus";

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
