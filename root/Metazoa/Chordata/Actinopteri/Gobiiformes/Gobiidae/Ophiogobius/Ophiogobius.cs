using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ophiogobius;

/// <summary>
/// Abstract class for Ophiogobius (genus).
/// NCBI TaxId: 990278
/// </summary>
public abstract class Ophiogobius : Gobiidae, IOphiogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophiogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990278;

    /// <inheritdoc />
    public virtual string GenusName => "Ophiogobius";

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
