using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Helcogramma;

/// <summary>
/// Abstract class for Helcogramma (genus).
/// NCBI TaxId: 490332
/// </summary>
public abstract class Helcogramma : Tripterygiidae, IHelcogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helcogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490332;

    /// <inheritdoc />
    public virtual string GenusName => "Helcogramma";

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
