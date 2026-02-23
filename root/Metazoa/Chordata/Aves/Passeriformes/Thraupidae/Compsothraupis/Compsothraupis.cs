using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Compsothraupis;

/// <summary>
/// Abstract class for Compsothraupis (genus).
/// NCBI TaxId: 1109034
/// </summary>
public abstract class Compsothraupis : Thraupidae, ICompsothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Compsothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109034;

    /// <inheritdoc />
    public virtual string GenusName => "Compsothraupis";

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
