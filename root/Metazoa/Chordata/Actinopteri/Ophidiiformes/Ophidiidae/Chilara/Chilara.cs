using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Chilara;

/// <summary>
/// Abstract class for Chilara (genus).
/// NCBI TaxId: 274687
/// </summary>
public abstract class Chilara : Ophidiidae, IChilara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274687;

    /// <inheritdoc />
    public virtual string GenusName => "Chilara";

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
