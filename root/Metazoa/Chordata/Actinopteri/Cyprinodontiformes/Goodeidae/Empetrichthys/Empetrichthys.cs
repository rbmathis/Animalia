using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Empetrichthys;

/// <summary>
/// Abstract class for Empetrichthys (genus).
/// NCBI TaxId: 33531
/// </summary>
public abstract class Empetrichthys : Goodeidae, IEmpetrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Empetrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33531;

    /// <inheritdoc />
    public virtual string GenusName => "Empetrichthys";

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
