using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Squalogadus;

/// <summary>
/// Abstract class for Squalogadus (genus).
/// NCBI TaxId: 332422
/// </summary>
public abstract class Squalogadus : Macrouridae, ISqualogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squalogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 332422;

    /// <inheritdoc />
    public virtual string GenusName => "Squalogadus";

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
