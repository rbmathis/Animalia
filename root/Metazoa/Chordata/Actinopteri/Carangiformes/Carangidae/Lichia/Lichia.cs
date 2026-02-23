using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Lichia;

/// <summary>
/// Abstract class for Lichia (genus).
/// NCBI TaxId: 425388
/// </summary>
public abstract class Lichia : Carangidae, ILichia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lichia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425388;

    /// <inheritdoc />
    public virtual string GenusName => "Lichia";

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
