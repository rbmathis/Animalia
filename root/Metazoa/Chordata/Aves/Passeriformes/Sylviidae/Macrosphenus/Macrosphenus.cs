using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Macrosphenus;

/// <summary>
/// Abstract class for Macrosphenus (genus).
/// NCBI TaxId: 237425
/// </summary>
public abstract class Macrosphenus : Sylviidae, IMacrosphenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrosphenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237425;

    /// <inheritdoc />
    public virtual string GenusName => "Macrosphenus";

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
