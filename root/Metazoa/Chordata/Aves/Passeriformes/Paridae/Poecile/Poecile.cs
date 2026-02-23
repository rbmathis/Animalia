using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Poecile;

/// <summary>
/// Abstract class for Poecile (genus).
/// NCBI TaxId: 142475
/// </summary>
public abstract class Poecile : Paridae, IPoecile
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poecile";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 142475;

    /// <inheritdoc />
    public virtual string GenusName => "Poecile";

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
