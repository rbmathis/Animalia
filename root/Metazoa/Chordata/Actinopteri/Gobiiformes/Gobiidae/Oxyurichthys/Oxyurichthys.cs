using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oxyurichthys;

/// <summary>
/// Abstract class for Oxyurichthys (genus).
/// NCBI TaxId: 493409
/// </summary>
public abstract class Oxyurichthys : Gobiidae, IOxyurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 493409;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyurichthys";

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
