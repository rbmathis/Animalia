using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Arctogadus;

/// <summary>
/// Abstract class for Arctogadus (genus).
/// NCBI TaxId: 185733
/// </summary>
public abstract class Arctogadus : Gadidae, IArctogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185733;

    /// <inheritdoc />
    public virtual string GenusName => "Arctogadus";

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
