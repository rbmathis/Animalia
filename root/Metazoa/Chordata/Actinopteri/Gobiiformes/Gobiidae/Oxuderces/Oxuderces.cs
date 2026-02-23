using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oxuderces;

/// <summary>
/// Abstract class for Oxuderces (genus).
/// NCBI TaxId: 1109016
/// </summary>
public abstract class Oxuderces : Gobiidae, IOxuderces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxuderces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109016;

    /// <inheritdoc />
    public virtual string GenusName => "Oxuderces";

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
