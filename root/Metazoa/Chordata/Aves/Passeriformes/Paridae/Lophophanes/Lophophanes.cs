using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Lophophanes;

/// <summary>
/// Abstract class for Lophophanes (genus).
/// NCBI TaxId: 156564
/// </summary>
public abstract class Lophophanes : Paridae, ILophophanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophophanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156564;

    /// <inheritdoc />
    public virtual string GenusName => "Lophophanes";

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
