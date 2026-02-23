using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Chodsigoa;

/// <summary>
/// Abstract class for Chodsigoa (genus).
/// NCBI TaxId: 269270
/// </summary>
public abstract class Chodsigoa : Soricidae, IChodsigoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chodsigoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269270;

    /// <inheritdoc />
    public virtual string GenusName => "Chodsigoa";

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
