using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Leptailurus;

/// <summary>
/// Abstract class for Leptailurus (genus).
/// NCBI TaxId: 61404
/// </summary>
public abstract class Leptailurus : Felidae, ILeptailurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptailurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61404;

    /// <inheritdoc />
    public virtual string GenusName => "Leptailurus";

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
