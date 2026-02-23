using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Liza;

/// <summary>
/// Abstract class for Liza (genus).
/// NCBI TaxId: 30803
/// </summary>
public abstract class Liza : Mugilidae, ILiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30803;

    /// <inheritdoc />
    public virtual string GenusName => "Liza";

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
