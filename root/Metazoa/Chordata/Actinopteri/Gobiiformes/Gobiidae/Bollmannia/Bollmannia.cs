using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bollmannia;

/// <summary>
/// Abstract class for Bollmannia (genus).
/// NCBI TaxId: 203282
/// </summary>
public abstract class Bollmannia : Gobiidae, IBollmannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bollmannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203282;

    /// <inheritdoc />
    public virtual string GenusName => "Bollmannia";

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
