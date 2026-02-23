using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Marcelogobius;

/// <summary>
/// Abstract class for Marcelogobius (genus).
/// NCBI TaxId: 3363438
/// </summary>
public abstract class Marcelogobius : Gobiidae, IMarcelogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marcelogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363438;

    /// <inheritdoc />
    public virtual string GenusName => "Marcelogobius";

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
