using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblygobius;

/// <summary>
/// Abstract class for Amblygobius (genus).
/// NCBI TaxId: 166730
/// </summary>
public abstract class Amblygobius : Gobiidae, IAmblygobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblygobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166730;

    /// <inheritdoc />
    public virtual string GenusName => "Amblygobius";

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
