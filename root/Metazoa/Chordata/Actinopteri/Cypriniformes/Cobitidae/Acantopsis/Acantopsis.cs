using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Acantopsis;

/// <summary>
/// Abstract class for Acantopsis (genus).
/// NCBI TaxId: 357280
/// </summary>
public abstract class Acantopsis : Cobitidae, IAcantopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 357280;

    /// <inheritdoc />
    public virtual string GenusName => "Acantopsis";

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
