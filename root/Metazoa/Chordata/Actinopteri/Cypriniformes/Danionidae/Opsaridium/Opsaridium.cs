using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Opsaridium;

/// <summary>
/// Abstract class for Opsaridium (genus).
/// NCBI TaxId: 451696
/// </summary>
public abstract class Opsaridium : Danionidae, IOpsaridium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opsaridium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451696;

    /// <inheritdoc />
    public virtual string GenusName => "Opsaridium";

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
