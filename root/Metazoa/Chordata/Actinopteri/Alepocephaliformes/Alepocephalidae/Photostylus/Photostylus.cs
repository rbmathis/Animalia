using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Photostylus;

/// <summary>
/// Abstract class for Photostylus (genus).
/// NCBI TaxId: 1696913
/// </summary>
public abstract class Photostylus : Alepocephalidae, IPhotostylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Photostylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696913;

    /// <inheritdoc />
    public virtual string GenusName => "Photostylus";

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
