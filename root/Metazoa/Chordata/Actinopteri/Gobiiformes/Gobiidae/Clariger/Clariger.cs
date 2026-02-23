using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Clariger;

/// <summary>
/// Abstract class for Clariger (genus).
/// NCBI TaxId: 249130
/// </summary>
public abstract class Clariger : Gobiidae, IClariger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clariger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249130;

    /// <inheritdoc />
    public virtual string GenusName => "Clariger";

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
