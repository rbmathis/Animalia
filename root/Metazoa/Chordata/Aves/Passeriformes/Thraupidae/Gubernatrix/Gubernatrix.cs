using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Gubernatrix;

/// <summary>
/// Abstract class for Gubernatrix (genus).
/// NCBI TaxId: 555260
/// </summary>
public abstract class Gubernatrix : Thraupidae, IGubernatrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gubernatrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555260;

    /// <inheritdoc />
    public virtual string GenusName => "Gubernatrix";

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
