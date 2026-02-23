using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Antimora;

/// <summary>
/// Abstract class for Antimora (genus).
/// NCBI TaxId: 473345
/// </summary>
public abstract class Antimora : Moridae, IAntimora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antimora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473345;

    /// <inheritdoc />
    public virtual string GenusName => "Antimora";

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
