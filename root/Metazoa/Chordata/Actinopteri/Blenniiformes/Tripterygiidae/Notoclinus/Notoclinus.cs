using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Notoclinus;

/// <summary>
/// Abstract class for Notoclinus (genus).
/// NCBI TaxId: 57831
/// </summary>
public abstract class Notoclinus : Tripterygiidae, INotoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57831;

    /// <inheritdoc />
    public virtual string GenusName => "Notoclinus";

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
