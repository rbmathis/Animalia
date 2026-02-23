using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gillichthys;

/// <summary>
/// Abstract class for Gillichthys (genus).
/// NCBI TaxId: 8221
/// </summary>
public abstract class Gillichthys : Gobiidae, IGillichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gillichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8221;

    /// <inheritdoc />
    public virtual string GenusName => "Gillichthys";

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
