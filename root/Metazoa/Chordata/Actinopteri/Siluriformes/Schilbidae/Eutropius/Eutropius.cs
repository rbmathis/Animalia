using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Eutropius;

/// <summary>
/// Abstract class for Eutropius (genus).
/// NCBI TaxId: 69933
/// </summary>
public abstract class Eutropius : Schilbidae, IEutropius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutropius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69933;

    /// <inheritdoc />
    public virtual string GenusName => "Eutropius";

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
