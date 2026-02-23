using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae.Bedotia;

/// <summary>
/// Abstract class for Bedotia (genus).
/// NCBI TaxId: 206111
/// </summary>
public abstract class Bedotia : Bedotiidae, IBedotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bedotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206111;

    /// <inheritdoc />
    public virtual string GenusName => "Bedotia";

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
