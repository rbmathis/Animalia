using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parrella;

/// <summary>
/// Abstract class for Parrella (genus).
/// NCBI TaxId: 1365707
/// </summary>
public abstract class Parrella : Gobiidae, IParrella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parrella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365707;

    /// <inheritdoc />
    public virtual string GenusName => "Parrella";

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
