using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Axoclinus;

/// <summary>
/// Abstract class for Axoclinus (genus).
/// NCBI TaxId: 57783
/// </summary>
public abstract class Axoclinus : Tripterygiidae, IAxoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Axoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57783;

    /// <inheritdoc />
    public virtual string GenusName => "Axoclinus";

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
