using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Epinnula;

/// <summary>
/// Abstract class for Epinnula (genus).
/// NCBI TaxId: 1262607
/// </summary>
public abstract class Epinnula : Gempylidae, IEpinnula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epinnula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1262607;

    /// <inheritdoc />
    public virtual string GenusName => "Epinnula";

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
