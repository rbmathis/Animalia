using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Leucopeza;

/// <summary>
/// Abstract class for Leucopeza (genus).
/// NCBI TaxId: 355631
/// </summary>
public abstract class Leucopeza : Parulidae, ILeucopeza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucopeza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 355631;

    /// <inheritdoc />
    public virtual string GenusName => "Leucopeza";

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
