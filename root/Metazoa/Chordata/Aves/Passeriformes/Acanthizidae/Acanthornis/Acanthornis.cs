using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Acanthornis;

/// <summary>
/// Abstract class for Acanthornis (genus).
/// NCBI TaxId: 720575
/// </summary>
public abstract class Acanthornis : Acanthizidae, IAcanthornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 720575;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthornis";

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
