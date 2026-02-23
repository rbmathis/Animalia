using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Setophaga;

/// <summary>
/// Abstract class for Setophaga (genus).
/// NCBI TaxId: 182948
/// </summary>
public abstract class Setophaga : Parulidae, ISetophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182948;

    /// <inheritdoc />
    public virtual string GenusName => "Setophaga";

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
