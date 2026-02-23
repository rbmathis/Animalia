using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Galaxiella;

/// <summary>
/// Abstract class for Galaxiella (genus).
/// NCBI TaxId: 89564
/// </summary>
public abstract class Galaxiella : Galaxiidae, IGalaxiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galaxiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89564;

    /// <inheritdoc />
    public virtual string GenusName => "Galaxiella";

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
