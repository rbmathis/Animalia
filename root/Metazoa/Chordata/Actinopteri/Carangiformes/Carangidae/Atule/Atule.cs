using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Atule;

/// <summary>
/// Abstract class for Atule (genus).
/// NCBI TaxId: 197571
/// </summary>
public abstract class Atule : Carangidae, IAtule
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atule";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 197571;

    /// <inheritdoc />
    public virtual string GenusName => "Atule";

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
