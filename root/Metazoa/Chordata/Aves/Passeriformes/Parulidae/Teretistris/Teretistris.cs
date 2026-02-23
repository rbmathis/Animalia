using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Teretistris;

/// <summary>
/// Abstract class for Teretistris (genus).
/// NCBI TaxId: 182950
/// </summary>
public abstract class Teretistris : Parulidae, ITeretistris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teretistris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182950;

    /// <inheritdoc />
    public virtual string GenusName => "Teretistris";

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
