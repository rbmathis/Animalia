using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Neosericornis;

/// <summary>
/// Abstract class for Neosericornis (genus).
/// NCBI TaxId: 2479996
/// </summary>
public abstract class Neosericornis : Acanthizidae, INeosericornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neosericornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2479996;

    /// <inheritdoc />
    public virtual string GenusName => "Neosericornis";

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
