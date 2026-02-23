using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Lotidae.Lota;

/// <summary>
/// Abstract class for Lota (genus).
/// NCBI TaxId: 69943
/// </summary>
public abstract class Lota : Lotidae, ILota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69943;

    /// <inheritdoc />
    public virtual string GenusName => "Lota";

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
