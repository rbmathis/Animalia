using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Nannostomus;

/// <summary>
/// Abstract class for Nannostomus (genus).
/// NCBI TaxId: 42606
/// </summary>
public abstract class Nannostomus : Lebiasinidae, INannostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42606;

    /// <inheritdoc />
    public virtual string GenusName => "Nannostomus";

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
