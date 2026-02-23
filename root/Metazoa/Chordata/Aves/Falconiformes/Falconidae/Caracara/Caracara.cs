using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Caracara;

/// <summary>
/// Abstract class for Caracara (genus).
/// NCBI TaxId: 1094195
/// </summary>
public abstract class Caracara : Falconidae, ICaracara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caracara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1094195;

    /// <inheritdoc />
    public virtual string GenusName => "Caracara";

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
