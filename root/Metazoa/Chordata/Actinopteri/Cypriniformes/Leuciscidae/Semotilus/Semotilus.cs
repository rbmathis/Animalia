using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Semotilus;

/// <summary>
/// Abstract class for Semotilus (genus).
/// NCBI TaxId: 67557
/// </summary>
public abstract class Semotilus : Leuciscidae, ISemotilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Semotilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67557;

    /// <inheritdoc />
    public virtual string GenusName => "Semotilus";

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
