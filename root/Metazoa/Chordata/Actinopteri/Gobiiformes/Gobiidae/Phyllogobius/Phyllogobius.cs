using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Phyllogobius;

/// <summary>
/// Abstract class for Phyllogobius (genus).
/// NCBI TaxId: 3362365
/// </summary>
public abstract class Phyllogobius : Gobiidae, IPhyllogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362365;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllogobius";

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
