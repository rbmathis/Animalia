using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Aplochiton;

/// <summary>
/// Abstract class for Aplochiton (genus).
/// NCBI TaxId: 66452
/// </summary>
public abstract class Aplochiton : Galaxiidae, IAplochiton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplochiton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66452;

    /// <inheritdoc />
    public virtual string GenusName => "Aplochiton";

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
