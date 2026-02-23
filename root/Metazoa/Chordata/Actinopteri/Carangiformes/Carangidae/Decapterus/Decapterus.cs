using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Decapterus;

/// <summary>
/// Abstract class for Decapterus (genus).
/// NCBI TaxId: 58219
/// </summary>
public abstract class Decapterus : Carangidae, IDecapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Decapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58219;

    /// <inheritdoc />
    public virtual string GenusName => "Decapterus";

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
