using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Myxine;

/// <summary>
/// Abstract class for Myxine (genus).
/// NCBI TaxId: 110555
/// </summary>
public abstract class Myxine : Myxinidae, IMyxine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myxine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110555;

    /// <inheritdoc />
    public virtual string GenusName => "Myxine";

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
