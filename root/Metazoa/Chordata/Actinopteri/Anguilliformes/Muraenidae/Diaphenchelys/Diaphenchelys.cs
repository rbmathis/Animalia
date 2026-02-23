using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Diaphenchelys;

/// <summary>
/// Abstract class for Diaphenchelys (genus).
/// NCBI TaxId: 1905335
/// </summary>
public abstract class Diaphenchelys : Muraenidae, IDiaphenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diaphenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1905335;

    /// <inheritdoc />
    public virtual string GenusName => "Diaphenchelys";

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
