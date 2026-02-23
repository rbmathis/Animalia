using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Eremichthys;

/// <summary>
/// Abstract class for Eremichthys (genus).
/// NCBI TaxId: 71762
/// </summary>
public abstract class Eremichthys : Leuciscidae, IEremichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71762;

    /// <inheritdoc />
    public virtual string GenusName => "Eremichthys";

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
