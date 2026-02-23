using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytes;

/// <summary>
/// Abstract class for Ammodytes (genus).
/// NCBI TaxId: 84620
/// </summary>
public abstract class Ammodytes : Ammodytidae, IAmmodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84620;

    /// <inheritdoc />
    public virtual string GenusName => "Ammodytes";

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
