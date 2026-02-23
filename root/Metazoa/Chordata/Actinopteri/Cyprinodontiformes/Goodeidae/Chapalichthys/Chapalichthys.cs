using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Chapalichthys;

/// <summary>
/// Abstract class for Chapalichthys (genus).
/// NCBI TaxId: 208327
/// </summary>
public abstract class Chapalichthys : Goodeidae, IChapalichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chapalichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208327;

    /// <inheritdoc />
    public virtual string GenusName => "Chapalichthys";

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
