using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Quintana;

/// <summary>
/// Abstract class for Quintana (genus).
/// NCBI TaxId: 417473
/// </summary>
public abstract class Quintana : Poeciliidae, IQuintana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Quintana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417473;

    /// <inheritdoc />
    public virtual string GenusName => "Quintana";

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
