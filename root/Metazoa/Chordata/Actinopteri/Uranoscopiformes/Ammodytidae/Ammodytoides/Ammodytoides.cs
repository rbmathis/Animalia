using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytoides;

/// <summary>
/// Abstract class for Ammodytoides (genus).
/// NCBI TaxId: 1414520
/// </summary>
public abstract class Ammodytoides : Ammodytidae, IAmmodytoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammodytoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1414520;

    /// <inheritdoc />
    public virtual string GenusName => "Ammodytoides";

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
