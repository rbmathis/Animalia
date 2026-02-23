using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Paraclinus;

/// <summary>
/// Abstract class for Paraclinus (genus).
/// NCBI TaxId: 57844
/// </summary>
public abstract class Paraclinus : Labrisomidae, IParaclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57844;

    /// <inheritdoc />
    public virtual string GenusName => "Paraclinus";

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
