using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Heteroclinus;

/// <summary>
/// Abstract class for Heteroclinus (genus).
/// NCBI TaxId: 57804
/// </summary>
public abstract class Heteroclinus : Clinidae, IHeteroclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57804;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroclinus";

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
