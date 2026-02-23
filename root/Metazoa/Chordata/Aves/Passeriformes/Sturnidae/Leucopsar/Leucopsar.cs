using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Leucopsar;

/// <summary>
/// Abstract class for Leucopsar (genus).
/// NCBI TaxId: 127928
/// </summary>
public abstract class Leucopsar : Sturnidae, ILeucopsar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucopsar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127928;

    /// <inheritdoc />
    public virtual string GenusName => "Leucopsar";

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
