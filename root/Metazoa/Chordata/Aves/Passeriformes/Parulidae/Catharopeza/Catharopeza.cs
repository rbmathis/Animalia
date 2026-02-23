using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Catharopeza;

/// <summary>
/// Abstract class for Catharopeza (genus).
/// NCBI TaxId: 182920
/// </summary>
public abstract class Catharopeza : Parulidae, ICatharopeza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catharopeza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182920;

    /// <inheritdoc />
    public virtual string GenusName => "Catharopeza";

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
