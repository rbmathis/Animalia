using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Calliclinus;

/// <summary>
/// Abstract class for Calliclinus (genus).
/// NCBI TaxId: 879805
/// </summary>
public abstract class Calliclinus : Labrisomidae, ICalliclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calliclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879805;

    /// <inheritdoc />
    public virtual string GenusName => "Calliclinus";

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
