using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Gymnomuraena;

/// <summary>
/// Abstract class for Gymnomuraena (genus).
/// NCBI TaxId: 876648
/// </summary>
public abstract class Gymnomuraena : Muraenidae, IGymnomuraena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnomuraena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 876648;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnomuraena";

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
