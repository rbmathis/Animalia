using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ecsenius;

/// <summary>
/// Abstract class for Ecsenius (genus).
/// NCBI TaxId: 57791
/// </summary>
public abstract class Ecsenius : Blenniidae, IEcsenius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ecsenius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57791;

    /// <inheritdoc />
    public virtual string GenusName => "Ecsenius";

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
