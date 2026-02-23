using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Anhingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Anhingidae.Anhinga;

/// <summary>
/// Abstract class for Anhinga (genus).
/// NCBI TaxId: 9212
/// </summary>
public abstract class Anhinga : Anhingidae, IAnhinga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anhinga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9212;

    /// <inheritdoc />
    public virtual string GenusName => "Anhinga";

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
