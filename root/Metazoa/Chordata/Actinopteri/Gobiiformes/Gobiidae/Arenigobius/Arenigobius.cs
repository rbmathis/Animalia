using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Arenigobius;

/// <summary>
/// Abstract class for Arenigobius (genus).
/// NCBI TaxId: 990263
/// </summary>
public abstract class Arenigobius : Gobiidae, IArenigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arenigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990263;

    /// <inheritdoc />
    public virtual string GenusName => "Arenigobius";

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
