using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Galaxias;

/// <summary>
/// Abstract class for Galaxias (genus).
/// NCBI TaxId: 51242
/// </summary>
public abstract class Galaxias : Galaxiidae, IGalaxias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galaxias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51242;

    /// <inheritdoc />
    public virtual string GenusName => "Galaxias";

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
