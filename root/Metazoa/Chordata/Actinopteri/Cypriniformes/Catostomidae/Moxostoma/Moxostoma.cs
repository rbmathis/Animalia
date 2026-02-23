using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Moxostoma;

/// <summary>
/// Abstract class for Moxostoma (genus).
/// NCBI TaxId: 117934
/// </summary>
public abstract class Moxostoma : Catostomidae, IMoxostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moxostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117934;

    /// <inheritdoc />
    public virtual string GenusName => "Moxostoma";

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
