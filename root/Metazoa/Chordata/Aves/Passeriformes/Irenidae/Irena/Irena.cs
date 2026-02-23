using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Irenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Irenidae.Irena;

/// <summary>
/// Abstract class for Irena (genus).
/// NCBI TaxId: 175118
/// </summary>
public abstract class Irena : Irenidae, IIrena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Irena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175118;

    /// <inheritdoc />
    public virtual string GenusName => "Irena";

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
