using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Parahyaena;

/// <summary>
/// Abstract class for Parahyaena (genus).
/// NCBI TaxId: 172270
/// </summary>
public abstract class Parahyaena : Hyaenidae, IParahyaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parahyaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172270;

    /// <inheritdoc />
    public virtual string GenusName => "Parahyaena";

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
