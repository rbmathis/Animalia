using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gymnogobius;

/// <summary>
/// Abstract class for Gymnogobius (genus).
/// NCBI TaxId: 178215
/// </summary>
public abstract class Gymnogobius : Gobiidae, IGymnogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 178215;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnogobius";

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
