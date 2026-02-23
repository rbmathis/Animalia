using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aruma;

/// <summary>
/// Abstract class for Aruma (genus).
/// NCBI TaxId: 203278
/// </summary>
public abstract class Aruma : Gobiidae, IAruma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aruma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203278;

    /// <inheritdoc />
    public virtual string GenusName => "Aruma";

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
