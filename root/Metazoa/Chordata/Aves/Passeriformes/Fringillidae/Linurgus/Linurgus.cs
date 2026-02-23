using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Linurgus;

/// <summary>
/// Abstract class for Linurgus (genus).
/// NCBI TaxId: 357700
/// </summary>
public abstract class Linurgus : Fringillidae, ILinurgus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Linurgus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 357700;

    /// <inheritdoc />
    public virtual string GenusName => "Linurgus";

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
