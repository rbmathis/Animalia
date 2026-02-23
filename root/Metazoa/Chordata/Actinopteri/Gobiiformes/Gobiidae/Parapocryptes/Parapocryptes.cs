using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parapocryptes;

/// <summary>
/// Abstract class for Parapocryptes (genus).
/// NCBI TaxId: 1365705
/// </summary>
public abstract class Parapocryptes : Gobiidae, IParapocryptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapocryptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365705;

    /// <inheritdoc />
    public virtual string GenusName => "Parapocryptes";

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
