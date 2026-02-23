using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Robinsichthys;

/// <summary>
/// Abstract class for Robinsichthys (genus).
/// NCBI TaxId: 2994270
/// </summary>
public abstract class Robinsichthys : Gobiidae, IRobinsichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Robinsichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2994270;

    /// <inheritdoc />
    public virtual string GenusName => "Robinsichthys";

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
