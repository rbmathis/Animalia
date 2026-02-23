using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Bradornis;

/// <summary>
/// Abstract class for Bradornis (genus).
/// NCBI TaxId: 248146
/// </summary>
public abstract class Bradornis : Muscicapidae, IBradornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bradornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248146;

    /// <inheritdoc />
    public virtual string GenusName => "Bradornis";

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
