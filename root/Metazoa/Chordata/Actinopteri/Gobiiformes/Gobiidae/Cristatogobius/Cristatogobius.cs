using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cristatogobius;

/// <summary>
/// Abstract class for Cristatogobius (genus).
/// NCBI TaxId: 1738889
/// </summary>
public abstract class Cristatogobius : Gobiidae, ICristatogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cristatogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1738889;

    /// <inheritdoc />
    public virtual string GenusName => "Cristatogobius";

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
