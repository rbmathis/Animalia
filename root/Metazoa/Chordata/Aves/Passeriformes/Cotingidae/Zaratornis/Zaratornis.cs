using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Zaratornis;

/// <summary>
/// Abstract class for Zaratornis (genus).
/// NCBI TaxId: 381441
/// </summary>
public abstract class Zaratornis : Cotingidae, IZaratornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zaratornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381441;

    /// <inheritdoc />
    public virtual string GenusName => "Zaratornis";

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
