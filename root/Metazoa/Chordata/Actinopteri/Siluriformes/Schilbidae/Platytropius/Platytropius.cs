using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Platytropius;

/// <summary>
/// Abstract class for Platytropius (genus).
/// NCBI TaxId: 175802
/// </summary>
public abstract class Platytropius : Schilbidae, IPlatytropius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platytropius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175802;

    /// <inheritdoc />
    public virtual string GenusName => "Platytropius";

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
