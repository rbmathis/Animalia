using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Meda;

/// <summary>
/// Abstract class for Meda (genus).
/// NCBI TaxId: 67548
/// </summary>
public abstract class Meda : Leuciscidae, IMeda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67548;

    /// <inheritdoc />
    public virtual string GenusName => "Meda";

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
