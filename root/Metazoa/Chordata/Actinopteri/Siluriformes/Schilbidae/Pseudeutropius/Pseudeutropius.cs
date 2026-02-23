using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Pseudeutropius;

/// <summary>
/// Abstract class for Pseudeutropius (genus).
/// NCBI TaxId: 390395
/// </summary>
public abstract class Pseudeutropius : Schilbidae, IPseudeutropius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudeutropius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390395;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudeutropius";

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
