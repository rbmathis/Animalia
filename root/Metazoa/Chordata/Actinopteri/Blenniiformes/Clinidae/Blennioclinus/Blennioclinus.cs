using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Blennioclinus;

/// <summary>
/// Abstract class for Blennioclinus (genus).
/// NCBI TaxId: 879803
/// </summary>
public abstract class Blennioclinus : Clinidae, IBlennioclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blennioclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879803;

    /// <inheritdoc />
    public virtual string GenusName => "Blennioclinus";

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
