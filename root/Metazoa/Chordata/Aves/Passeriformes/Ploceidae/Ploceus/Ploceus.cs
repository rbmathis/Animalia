using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Ploceus;

/// <summary>
/// Abstract class for Ploceus (genus).
/// NCBI TaxId: 135447
/// </summary>
public abstract class Ploceus : Ploceidae, IPloceus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ploceus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135447;

    /// <inheritdoc />
    public virtual string GenusName => "Ploceus";

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
