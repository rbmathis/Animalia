using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Vermivora;

/// <summary>
/// Abstract class for Vermivora (genus).
/// NCBI TaxId: 62258
/// </summary>
public abstract class Vermivora : Parulidae, IVermivora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vermivora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62258;

    /// <inheritdoc />
    public virtual string GenusName => "Vermivora";

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
