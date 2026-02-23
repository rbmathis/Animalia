using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mesogobius;

/// <summary>
/// Abstract class for Mesogobius (genus).
/// NCBI TaxId: 320560
/// </summary>
public abstract class Mesogobius : Gobiidae, IMesogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320560;

    /// <inheritdoc />
    public virtual string GenusName => "Mesogobius";

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
