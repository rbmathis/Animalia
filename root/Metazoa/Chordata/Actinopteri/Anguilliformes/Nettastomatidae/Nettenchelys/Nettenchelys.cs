using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Nettenchelys;

/// <summary>
/// Abstract class for Nettenchelys (genus).
/// NCBI TaxId: 2726663
/// </summary>
public abstract class Nettenchelys : Nettastomatidae, INettenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nettenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726663;

    /// <inheritdoc />
    public virtual string GenusName => "Nettenchelys";

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
