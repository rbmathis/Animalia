using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Ramsayornis;

/// <summary>
/// Abstract class for Ramsayornis (genus).
/// NCBI TaxId: 266378
/// </summary>
public abstract class Ramsayornis : Meliphagidae, IRamsayornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramsayornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266378;

    /// <inheritdoc />
    public virtual string GenusName => "Ramsayornis";

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
