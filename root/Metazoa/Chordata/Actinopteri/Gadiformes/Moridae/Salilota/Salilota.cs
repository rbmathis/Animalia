using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Salilota;

/// <summary>
/// Abstract class for Salilota (genus).
/// NCBI TaxId: 458606
/// </summary>
public abstract class Salilota : Moridae, ISalilota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salilota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458606;

    /// <inheritdoc />
    public virtual string GenusName => "Salilota";

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
