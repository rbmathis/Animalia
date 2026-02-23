using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pitohui;

/// <summary>
/// Abstract class for Pitohui (genus).
/// NCBI TaxId: 156165
/// </summary>
public abstract class Pitohui : Passeriformes, IPitohui
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pitohui";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156165;

    /// <inheritdoc />
    public virtual string GenusName => "Pitohui";

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
