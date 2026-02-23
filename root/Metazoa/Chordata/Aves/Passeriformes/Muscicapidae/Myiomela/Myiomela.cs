using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Myiomela;

/// <summary>
/// Abstract class for Myiomela (genus).
/// NCBI TaxId: 758457
/// </summary>
public abstract class Myiomela : Muscicapidae, IMyiomela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiomela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758457;

    /// <inheritdoc />
    public virtual string GenusName => "Myiomela";

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
