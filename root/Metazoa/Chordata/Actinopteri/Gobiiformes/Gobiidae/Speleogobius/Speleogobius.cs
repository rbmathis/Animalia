using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Speleogobius;

/// <summary>
/// Abstract class for Speleogobius (genus).
/// NCBI TaxId: 1365716
/// </summary>
public abstract class Speleogobius : Gobiidae, ISpeleogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speleogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365716;

    /// <inheritdoc />
    public virtual string GenusName => "Speleogobius";

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
