using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Myxodes;

/// <summary>
/// Abstract class for Myxodes (genus).
/// NCBI TaxId: 57827
/// </summary>
public abstract class Myxodes : Clinidae, IMyxodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myxodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57827;

    /// <inheritdoc />
    public virtual string GenusName => "Myxodes";

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
