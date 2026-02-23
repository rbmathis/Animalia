using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Phycidae.Phycis;

/// <summary>
/// Abstract class for Phycis (genus).
/// NCBI TaxId: 163114
/// </summary>
public abstract class Phycis : Phycidae, IPhycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163114;

    /// <inheritdoc />
    public virtual string GenusName => "Phycis";

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
