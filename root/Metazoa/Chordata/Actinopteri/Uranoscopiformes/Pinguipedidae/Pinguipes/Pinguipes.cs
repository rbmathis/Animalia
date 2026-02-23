using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Pinguipes;

/// <summary>
/// Abstract class for Pinguipes (genus).
/// NCBI TaxId: 458597
/// </summary>
public abstract class Pinguipes : Pinguipedidae, IPinguipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinguipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458597;

    /// <inheritdoc />
    public virtual string GenusName => "Pinguipes";

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
