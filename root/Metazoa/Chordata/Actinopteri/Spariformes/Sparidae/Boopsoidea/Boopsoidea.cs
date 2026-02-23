using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Boopsoidea;

/// <summary>
/// Abstract class for Boopsoidea (genus).
/// NCBI TaxId: 119687
/// </summary>
public abstract class Boopsoidea : Sparidae, IBoopsoidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boopsoidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119687;

    /// <inheritdoc />
    public virtual string GenusName => "Boopsoidea";

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
