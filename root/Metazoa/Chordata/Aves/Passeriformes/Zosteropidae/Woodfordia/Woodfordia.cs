using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Woodfordia;

/// <summary>
/// Abstract class for Woodfordia (genus).
/// NCBI TaxId: 589862
/// </summary>
public abstract class Woodfordia : Zosteropidae, IWoodfordia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Woodfordia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589862;

    /// <inheritdoc />
    public virtual string GenusName => "Woodfordia";

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
