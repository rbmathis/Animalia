using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Myiothlypis;

/// <summary>
/// Abstract class for Myiothlypis (genus).
/// NCBI TaxId: 1851188
/// </summary>
public abstract class Myiothlypis : Parulidae, IMyiothlypis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiothlypis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1851188;

    /// <inheritdoc />
    public virtual string GenusName => "Myiothlypis";

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
