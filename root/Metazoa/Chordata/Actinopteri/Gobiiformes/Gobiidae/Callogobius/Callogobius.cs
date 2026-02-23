using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Callogobius;

/// <summary>
/// Abstract class for Callogobius (genus).
/// NCBI TaxId: 166738
/// </summary>
public abstract class Callogobius : Gobiidae, ICallogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166738;

    /// <inheritdoc />
    public virtual string GenusName => "Callogobius";

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
