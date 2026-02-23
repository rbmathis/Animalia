using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Phainopepla;

/// <summary>
/// Abstract class for Phainopepla (genus).
/// NCBI TaxId: 161652
/// </summary>
public abstract class Phainopepla : Bombycillidae, IPhainopepla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phainopepla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161652;

    /// <inheritdoc />
    public virtual string GenusName => "Phainopepla";

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
