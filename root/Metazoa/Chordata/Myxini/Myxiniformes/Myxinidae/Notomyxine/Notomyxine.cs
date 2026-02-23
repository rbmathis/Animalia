using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Notomyxine;

/// <summary>
/// Abstract class for Notomyxine (genus).
/// NCBI TaxId: 458587
/// </summary>
public abstract class Notomyxine : Myxinidae, INotomyxine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notomyxine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458587;

    /// <inheritdoc />
    public virtual string GenusName => "Notomyxine";

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
