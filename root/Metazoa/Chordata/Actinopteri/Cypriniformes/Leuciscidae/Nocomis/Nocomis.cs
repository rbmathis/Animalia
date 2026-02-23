using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Nocomis;

/// <summary>
/// Abstract class for Nocomis (genus).
/// NCBI TaxId: 86915
/// </summary>
public abstract class Nocomis : Leuciscidae, INocomis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nocomis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86915;

    /// <inheritdoc />
    public virtual string GenusName => "Nocomis";

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
