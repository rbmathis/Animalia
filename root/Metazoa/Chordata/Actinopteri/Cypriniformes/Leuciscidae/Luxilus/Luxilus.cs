using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Luxilus;

/// <summary>
/// Abstract class for Luxilus (genus).
/// NCBI TaxId: 33535
/// </summary>
public abstract class Luxilus : Leuciscidae, ILuxilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luxilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33535;

    /// <inheritdoc />
    public virtual string GenusName => "Luxilus";

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
